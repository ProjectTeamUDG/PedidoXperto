using System.Drawing.Drawing2D;
using System.Text;
using ApisMicrosip;
using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;
using PedidoXperto.Logic;
using static PedidoXperto.ChildForms.SearchCliente;
using ApiBas = ApisMicrosip.ApiMspBasicaExt;
using ApiVen = ApisMicrosip.ApiMspVentasExt;
namespace PedidoXperto.ChildForms
{
    public partial class FormCrearPedido : Form
    {
        private decimal descuentoPorCliente = -1;
        private PriorityQueue<string, int> recomendados;
        private HashSet<string> setRecomendados;
        List<List<string>> vendedores = new List<List<string>>();
        public enum ColTabla
        {
            CodigoBarras = 0,
            Descripcion = 1,
            Cantidad = 2,
            Precio = 3,
            Descuento = 4,
            Iva = 5,
            Total = 6
        }
        public FormCrearPedido()
        {
            InitializeComponent();
            CargarVendedores();
            descuentoPorCliente = 0;
            recomendados = new();
            setRecomendados = new();
        }
        public void CargarComboBox(List<List<string>> vendedores)
        {
            var nombres = new List<string>();
            foreach (var vendedor in vendedores)
            {
                nombres.Add(vendedor[1]);
            }
            // Limpiar y agregar los nombres
            Cb_Vendedor.Items.Clear();
            Cb_Vendedor.Items.AddRange(nombres.ToArray());

            // Configurar autocompletado
            Cb_Vendedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cb_Vendedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Cb_Vendedor.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            Cb_Vendedor.AutoCompleteCustomSource.AddRange(nombres.ToArray());
        }
        public void CargarVendedores()
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con.Open();
                string query = "SELECT VENDEDOR_ID, NOMBRE FROM VENDEDORES WHERE OCULTO = 'N'";
                FbCommand command = new FbCommand(query, con);
                FbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<string> vendedor = new List<string>();
                    vendedor.Add(reader.GetString(0));
                    vendedor.Add(reader.GetString(1));
                    vendedores.Add(vendedor);
                }
                CargarComboBox(vendedores);
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                con.Close();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_clienteId_TextChanged(object sender, EventArgs e)
        {
            if (InvalidText(txtBox_clienteId.Text))
                return;


            var cliente_id = DataBridge.SearchClient(txtBox_clienteId.Text);
            if (cliente_id == null)
            {
                txtBox_clienteNombre.Text = "Cliente no encontrado";
            }
            else
            {
                var name = DataBridge.GetClientName(cliente_id);
                if (name == null)
                {
                    txtBox_clienteNombre.Text = "Cliente no encontrado";
                    return;
                }
                txtBox_clienteNombre.Text = name;
                //Obtiene el descuento por cliente una sola vez
                descuentoPorCliente = decimal.Parse(DataBridge.GetDiscountByClient(cliente_id) ?? "-1");
                //Actualiza los valores con el nuevo descuento
                ActualizarPrecios();
            }
        }
        private int ConectaBD()
        {

            ApiBas.SetErrorHandling(0, 0);
            if (GlobalSettings.Instance.Bd == 0)
                GlobalSettings.Instance.Bd = ApiBas.NewDB();
            //Objeto transaccion
            GlobalSettings.Instance.Trn = ApiBas.NewTrn(GlobalSettings.Instance.Bd, 3);
            string path = GlobalSettings.Instance.Ip + ":" + GlobalSettings.Instance.Direccion;
            int conecta = ApiBas.DBConnect(GlobalSettings.Instance.Bd, path, GlobalSettings.Instance.User, GlobalSettings.Instance.Pw);
            StringBuilder obtieneError = new StringBuilder(1000);
            int codigoError = ApiBas.GetLastErrorMessage(obtieneError);
            String mensajeError = codigoError.ToString();
            if (codigoError > 0)
            {
                MessageBox.Show(obtieneError.ToString());
                return 0;
            }
            else
            {
                return 1;
            }

        }
        private bool InvalidText(string codigo, int minLength = 3)
        {
            return string.IsNullOrWhiteSpace(codigo) || codigo.Length < minLength;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            int conectar = ConectaBD();
            if (conectar != 1)
            {
                MessageBox.Show("Error al conectar a la base de datos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiMspBasicaExt.DBConnected(GlobalSettings.Instance.Bd);
            ApiMspVentasExt.SetDBVentas(GlobalSettings.Instance.Bd);
            string cliente_id = "";
            GetFireBirdValue getFireBirdValue = new GetFireBirdValue();
            if (txtBox_clienteId.Text != string.Empty)
            {
                string query = "SELECT CLIENTE_ID FROM CLAVES_CLIENTES WHERE CLAVE_CLIENTE = '" + txtBox_clienteId.Text + "'";
                cliente_id = getFireBirdValue.GetValue(query);
            }
            string vendedor_id = "";

            var vendedor = vendedores.FirstOrDefault(v => v[1] == Cb_Vendedor.Text);
            if (vendedor != null)
            {
                vendedor_id = vendedor[0];
            }
            int DoctoId = ApiMspVentasExt.NuevoPedido(DateTime.Now.ToString(), "P", int.Parse(cliente_id), 0, 108401, "", "P", 0, "", "", int.Parse(vendedor_id), 0, 0, 0);
            ApiMspVentasExt.GetDoctoVeId(ref DoctoId);
            for (int k = 0; k < Tabla.Rows.Count; k++)
            {
                if (Tabla.Rows[k].Cells[0].Value == null)
                {
                    break;
                }
                string query = "SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + Tabla.Rows[k].Cells[0].Value.ToString() + "'";
                string articulo_id = getFireBirdValue.GetValue(query);
                ApiMspVentasExt.RenglonPedido(int.Parse(articulo_id), double.Parse(Tabla.Rows[k].Cells[2].Value.ToString()), double.Parse(Tabla.Rows[k].Cells[3].Value.ToString()), double.Parse(Tabla.Rows[k].Cells[4].Value.ToString()), "");
            }
            if (ApiMspVentasExt.AplicaPedido() != 0)
            {
                MessageBox.Show("PROBLEMAS CON GENERAR EL PEDIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                CrearLibres(DoctoId.ToString());
                ApiBas.DBDisconnect(GlobalSettings.Instance.Bd);
                MessageBox.Show("Pedido Generado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_clienteId.Text = string.Empty;
                txtBox_clienteNombre.Text = string.Empty;
                Tabla.Rows.Clear();
                Cb_Vendedor.Focus();
                //precioTotal.Text = "$ 0.00";
                valorDescuento.Text = "$ 0.00";
            }
        }
        public void CrearLibres(string DoctoId)
        {
            // Crear y abrir la conexión
            using (FbConnection connection = new FbConnection(GlobalSettings.Instance.StringConnection))
            {
                try
                {
                    // Abrir la conexión a la base de datos
                    connection.Open();
                    string query = "INSERT INTO LIBRES_PED_VE (DOCTO_VE_ID, VERIFICADO_X_SOFTWARE) " +
                    "VALUES (@DoctoId, @VerificadoXSoftware)";
                    // Crear el comando Firebird con la consulta SQL y la conexión
                    using (FbCommand command = new FbCommand(query, connection))
                    {
                        // Agregar los parámetros con sus valores
                        command.Parameters.AddWithValue("@DoctoId", DoctoId);
                        command.Parameters.AddWithValue("@VerificadoXSoftware", 0);

                        // Ejecutar el comando SQL
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public Tuple<decimal, decimal, decimal> CalcularTotalesTabla()
        {
            // Verifica si la tabla tiene filas/articulos
            if (Tabla.Rows.Count < 1)
                return new(0, 0, 0);

            decimal totalPrecio = 0;
            decimal totalDescuento = 0;
            decimal totalIva = 0;
            decimal cantidad, precio;

            for (int i = 0; i < Tabla.Rows.Count; i++)//Por cada articulo
            {
                if (Tabla.Rows[i].Cells[(int)ColTabla.Total].Value == null ||
                Tabla.Rows[i].Cells[(int)ColTabla.Cantidad].Value == null ||
                Tabla.Rows[i].Cells[(int)ColTabla.Precio].Value == null
                ) continue; //Valor nulo? no deberia ser posible

                // 1) Extraer y convertir una sola vez
                decimal porcentajeIva = decimal.Parse( //40
                    Tabla.Rows[i].Cells[(int)ColTabla.Iva].Value.ToString()) / 100m;
                decimal porcentajeDescuento = CalcularDescuentoArticulo(Tabla.Rows[i].Cells[(int)ColTabla.CodigoBarras].Value.ToString()) / 100m;
                Tabla.Rows[i].Cells[(int)ColTabla.Descuento].Value = porcentajeDescuento * 100; //Lo guardamos como porcentaje
                cantidad = decimal.Parse(Tabla.Rows[i].Cells[(int)ColTabla.Cantidad].Value.ToString());
                precio = decimal.Parse(Tabla.Rows[i].Cells[(int)ColTabla.Precio].Value.ToString());

                if (cantidad <= 0 || precio <= 0) continue;

                decimal cantidadBase = cantidad * precio;
                // 3) Calcular descuento
                decimal cantidadDescuento = cantidadBase * porcentajeDescuento;
                decimal totalDespuesDescuento = cantidadBase - cantidadDescuento;

                Tabla.Rows[i].Cells[(int)ColTabla.Total].Value = totalDespuesDescuento;

                // 4) Calcular IVA sobre el neto
                decimal cantidadIva = totalDespuesDescuento * porcentajeIva;
                // Tabla.Rows[i].Cells[(int)ColTabla.Iva].Value = cantidadIva;

                // 5) Acumular en tus totales
                totalPrecio += cantidadBase;        // suma del precio sin descuentos ni IVA
                totalDescuento += cantidadDescuento;    // suma de todos los descuentos
                totalIva += cantidadIva;         // suma de todo el IVA calculado

            }
            return new(totalPrecio, totalDescuento, totalIva);
        }

        public void ActualizarPrecios()
        {
            Tuple<decimal, decimal, decimal> totales = CalcularTotalesTabla();
            //precioTotal.Text = "$ " + Math.Round(totales.Item1, 2);
            valorDescuento.Text = "$ " + Math.Round(totales.Item2, 2);
            precioConDescuento.Text = "$ " + Math.Round(totales.Item1 - totales.Item2 + totales.Item3, 2);
        }

        private void txtBox_clienteId_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBox_clienteNombre.Text != "Cliente no encontrado")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;

                    if (Tabla.Rows.Count == 0)
                    {
                        Tabla.Rows.Add();
                    }
                    else if (Tabla.Rows.Count != 0 && Tabla.Rows[Tabla.Rows.Count - 1].Cells[0].Value != null)
                        Tabla.Rows.Add();

                    Tabla.Rows[Tabla.Rows.Count - 1].Height = 40;
                    Tabla.Focus();
                    Tabla.Rows[Tabla.Rows.Count - 1].Cells[0].Selected = true;
                }
            }
        }

        /// <summary>
        /// Añade los articulos recomendados a la tabla de recomendados, si hay 6 o más no añade más
        /// </summary>
        private async Task ManejarTablaRecomendado(string clave_principal)
        {
            //IA
            List<string> resultados = await DataBridge.ObtenerRecomendado(clave_principal);

            if (resultados == null || resultados.Count == 0)
                return;

            int prioridadExistente = 0, prioridadNueva = 0;
            foreach (string result in resultados)
            {
                // Si ya existe en la tabla de recomendados, no lo añade
                if (setRecomendados.Contains(result)) continue;

                // Si llego al limite de 6 elementos, saca el de menor prioridad
                recomendados.TryPeek(out _, out prioridadExistente);
                if (recomendados.Count >= 6 && prioridadNueva < prioridadExistente)//menos es mejor aqui
                {
                    // Elimina el elemento de menor prioridad
                    setRecomendados.Remove(recomendados.Peek());
                    recomendados.Dequeue();
                }
                // Añade el nuevo elemento con la prioridad nueva
                setRecomendados.Add(result);
                recomendados.Enqueue(result, prioridadNueva++);
            }
        }

        private void ActualizarTablaRecomendados()
        {
            PriorityQueue<string, int> temp = new();
            TablaRecomendados.Rows.Clear();
            int prioridadExistente = 0;
            string recomendado;
            while (recomendados.Count > 0)
            {
                recomendados.TryDequeue(out recomendado, out prioridadExistente);
                string[] InfoArt = new GetFireBirdValue().BuscarDatosArticulos(recomendado);
                TablaRecomendados.Rows.Add(recomendado, InfoArt[1]);
                TablaRecomendados.Rows[TablaRecomendados.CurrentCell.RowIndex].Height = 40;
                TablaRecomendados.ClearSelection();
                temp.Enqueue(recomendado, prioridadExistente);
            }
            recomendados = temp;
        }

        /// <summary>
        /// Calcula el descuento por cliente y por artículo
        /// descuento por cliente ya debe tener un valor valido a este punto
        /// </summary>
        /// <param name="_articulo_id"></param>
        private decimal CalcularDescuentoArticulo(string _articulo_id)
        {
            decimal _descuentoPorArticulo = decimal.Parse(DataBridge.GetDiscountByArticle(_articulo_id) ?? "-1");

            // Calcular el descuento total efectivo usando la fórmula
            decimal _descuentoTotal =
            1 - (
                (1 - (descuentoPorCliente != decimal.MinusOne ? descuentoPorCliente / 100m : 0m))//Si hay descuento por cliente, se aplica
                *
                (1 - (_descuentoPorArticulo != decimal.MinusOne ? _descuentoPorArticulo : 0m))//Si hay descuento por articulo, se aplica
                );
            //Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Descuento].Value = _descuentoTotal;
            return _descuentoTotal *= 100; // Convertir a porcentaje y mostrar el resultado
        }

        private async void LlenarDatosArticulo()
        {
            //string codigoBarras = Tabla.CurrentCell.Value.ToString();
            string codigoBarras = "";

            if (GlobalSettings.Instance.Crear_clave != null)
            {
                codigoBarras = GlobalSettings.Instance.Crear_clave;
                GlobalSettings.Instance.Crear_clave = null;
                Tabla.CurrentCell.Value = codigoBarras;
            }
            else
            {
                codigoBarras = Tabla.CurrentCell.Value == null ? "" : Tabla.CurrentCell.Value.ToString();
                if (InvalidText(codigoBarras))
                    return;
            }

            GetFireBirdValue bridge = new();

            string[] DatosArticulo = new string[2];

            DatosArticulo = bridge.BuscarDatosArticulos(codigoBarras);

            if (DatosArticulo != null)
            {

                string Clave_Principal = DatosArticulo[0];
                string articulo_id = DataBridge.GetArticuloId(Clave_Principal);
                Tabla.EndEdit();
                Tabla.CurrentRow.Cells[(int)ColTabla.CodigoBarras].Value = Clave_Principal;
                Tabla.CurrentRow.Cells[(int)ColTabla.Descripcion].Value = DatosArticulo[1];
                Tabla.CurrentRow.Cells[1].ReadOnly = true;
                Tabla.CurrentRow.Cells[(int)ColTabla.Precio].Value = DatosArticulo[2];
                Tabla.CurrentRow.Cells[(int)ColTabla.Iva].Value = bridge.GetImpuestoArticulo(Clave_Principal)[0];
                Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Cantidad].Value = 1;
                Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Descuento].Value = CalcularDescuentoArticulo(articulo_id);//nos lo devuelve directo 16
                Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Total].Value = 0;
                Tabla.CurrentCell = Tabla.CurrentRow.Cells[(int)ColTabla.Cantidad];
                Tabla.BeginEdit(true);

                await ManejarTablaRecomendado(Clave_Principal);

                ActualizarTablaRecomendados();
            }
            else
                MessageBox.Show("Artículo no encontrado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Tabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Tabla.CurrentRow == null)
                return;

            // Verifica que la celda en la columna 0 no sea nula ni vacía
            var celda0 = Tabla.CurrentRow.Cells[0].Value;
            if (celda0 == null || string.IsNullOrWhiteSpace(celda0.ToString()))
                return;
            if (Tabla.CurrentCell.ColumnIndex == (int)ColTabla.CodigoBarras)//Es cuando llena la celda de clave_articulo
            {
                if (Tabla.CurrentCell.Value == null || Tabla.CurrentCell.Value.ToString() == string.Empty)
                {
                    Tabla.CurrentRow.Cells[1].ReadOnly = false;
                    return;
                }
                if(GlobalSettings.Instance.editandoclave == true)
                {
                    GlobalSettings.Instance.editandoclave = false;
                    return;
                }
                LlenarDatosArticulo();//Llena los datos de un articulo
            }
            else if (Tabla.CurrentCell.ColumnIndex == (int)ColTabla.Cantidad)
            {
                if( Tabla.CurrentCell.Value == null || Tabla.CurrentRow.Cells[(int)ColTabla.Cantidad].Value == string.Empty || Tabla.CurrentCell.Value.ToString() == "0"){
                    Tabla.Rows[Tabla.Rows.Count - 1].Cells[(int)ColTabla.Cantidad].Value = 1;
                }
                else if ( Tabla.CurrentCell.Value.ToString().All(char.IsDigit) && decimal.Parse(Tabla.CurrentCell.Value.ToString()) > 0)
                {

                    if ((Tabla.CurrentCell.RowIndex) + 1 == Tabla.Rows.Count)//Si estamos en la ultima, agrega una fila nueva
                    {
                        Tabla.Rows.Add();
                        Tabla.Rows[Tabla.CurrentCell.RowIndex + 1].Height = 40;
                        int nextRow = e.RowIndex + 1;
                        this.BeginInvoke(new MethodInvoker(() =>
                        {
                            Tabla.CurrentCell = Tabla.Rows[nextRow].Cells[0];
                        }));
                    }
                }
                ActualizarPrecios();
            }        
        }

        private void Cb_Vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void DesplegarSearchmenu()
        {
            string parametros = Tabla.CurrentCell.EditedFormattedValue?.ToString() ?? "";
            int ColumnIndex = Tabla.CurrentCell.ColumnIndex;
            if (parametros == string.Empty)//Si esta vacio no disparamos nada
                return;

            SearchMenu buscar = new SearchMenu(parametros,ColumnIndex);

            //buscar.Tabla.Rows.Clear();
            buscar.Tabla.Focus();
            buscar.Tabla.Select();
            buscar.ShowDialog();

            if (GlobalSettings.Instance.Crear_clave != null)
            {
                LlenarDatosArticulo();
                Tabla.CurrentCell = Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Cantidad];
                Tabla.BeginEdit(true);
            }
        }

        private void Tabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if (Tabla.CurrentCell != null && Tabla.CurrentCell.ColumnIndex == 1)
                {
                    DesplegarSearchmenu();
                    e.Handled = true; // Opcional, previene otros efectos
                }
                else if(Tabla.CurrentCell != null && Tabla.CurrentCell.ColumnIndex == 0)
                {
                    DesplegarSearchmenu();
                    e.Handled = true; // Opcional, previene otros efectos
                }
            }
            else if (e.Control && e.KeyCode == Keys.Delete)  // Verifica que Ctrl + Supr se presionen
            {
                if (Tabla.CurrentRow == null) return;
                // Elimina la fila seleccionada
                Tabla.Rows.Remove(Tabla.CurrentRow);
                ActualizarPrecios();
                e.Handled = true; // Opcional, previene otros efectos
                if (Tabla.Rows.Count == 0)
                {
                    Tabla.Rows.Add(); // Añade una nueva fila si no hay filas restantes
                }
            }
            else if (e.KeyCode == Keys.F9)
            {
                if (Tabla.CurrentRow.Cells[0].Value != null && (Tabla.CurrentCell.ColumnIndex == 1 || Tabla.CurrentCell.ColumnIndex == 0))
                {
                    Existencias existencias = new Existencias();
                    string articuloid = DataBridge.GetArticuloId(Tabla.CurrentRow.Cells[0].Value.ToString());
                    string Exalmacen = DataBridge.GetExistencia(articuloid, "108401");
                    string Extienda = DataBridge.GetExistencia(articuloid, "108403");
                    existencias.Descripcion.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
                    existencias.ExistenciaAlmacen.Text = Exalmacen;
                    existencias.ExistenciaTienda.Text = Extienda;
                    existencias.ShowDialog();
                    e.Handled = true; // Opcional, previene otros efectos
                }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                if (Tabla.CurrentRow.Index == Tabla.Rows.Count - 1 && Tabla.Rows[Tabla.Rows.Count - 1].Cells[0].Value != null)
                {
                    Tabla.Rows.Add();
                    int columnIndex = Tabla.CurrentCell.ColumnIndex;
                    Tabla.CurrentCell = Tabla.Rows[Tabla.Rows.Count - 1].Cells[columnIndex];
                    e.Handled = true; // Opcional, previene otros efectos
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (Tabla.CurrentRow.Index == Tabla.Rows.Count - 1 && Tabla.Rows[Tabla.Rows.Count - 1].Cells[0].Value == null)
                {
                    int columnIndex = Tabla.CurrentCell.ColumnIndex;

                    // Eliminar la última fila
                    Tabla.Rows.RemoveAt(Tabla.Rows.Count - 1);

                    // Calcular nueva fila después de eliminar
                    int nuevaFila = Tabla.Rows.Count - 1;

                    if (nuevaFila >= 0 && columnIndex < Tabla.ColumnCount)
                    {
                        Tabla.CurrentCell = Tabla.Rows[nuevaFila].Cells[columnIndex];
                    }

                    e.Handled = true; // Opcional, previene otros efectos
                }
            }
        }



        private void Tabla_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                // Evita suscripciones múltiples
                tb.KeyDown -= Tabla_KeyDown;
                tb.KeyDown += Tabla_KeyDown;
            }
            if (Tabla.CurrentCell.ColumnIndex == 1 && e.Control is TextBox tb2)
            {
                // Remueve cualquier controlador anterior para evitar duplicados
                tb2.KeyPress -= Tabla_KeyPress;
                tb2.KeyPress += Tabla_KeyPress;
            }
        }

        private void RemoverRecomendado(string clave_principal)
        {
            setRecomendados.Remove(clave_principal);
            PriorityQueue<string, int> temp = new();
            int prioridadExistente = 0;
            string recomendado;
            while (recomendados.Count > 0)
            {
                recomendados.TryDequeue(out recomendado, out prioridadExistente);
                if (recomendado == clave_principal) continue;
                temp.Enqueue(recomendado, prioridadExistente);
            }
            recomendados = temp;
        }

        private void TablaRecomendados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarDatosArticulo();//Del articulo anterior a el anadido, por recomendar
            if(Tabla.Rows[Tabla.Rows.Count-1].Cells[(int)ColTabla.CodigoBarras].Value == null)
            {
                Tabla.Rows[Tabla.Rows.Count-1].Cells[(int)ColTabla.CodigoBarras].Value = TablaRecomendados.CurrentRow.Cells[(int)ColTabla.CodigoBarras].Value.ToString();
                Tabla.Rows[Tabla.Rows.Count-1].Cells[(int)ColTabla.Descripcion].Value = TablaRecomendados.CurrentRow.Cells[(int)ColTabla.Descripcion].Value.ToString();
            }
            else
                Tabla.Rows.Add(TablaRecomendados.CurrentRow.Cells[(int)ColTabla.CodigoBarras].Value.ToString(), TablaRecomendados.CurrentRow.Cells[(int)ColTabla.Descripcion].ToString());
            Tabla.CurrentCell = Tabla.Rows[Tabla.Rows.Count - 1].Cells[(int)ColTabla.CodigoBarras];
            LlenarDatosArticulo();

            RemoverRecomendado(TablaRecomendados.CurrentRow.Cells[(int)ColTabla.CodigoBarras].Value.ToString());
            ActualizarTablaRecomendados();
            
        }

        private void Tabla_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtBox_clienteNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBox_clienteNombre.Text != "Cliente no encontrado")
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    e.SuppressKeyPress = true;
                    if (Tabla.Rows.Count == 0)
                    {
                        Tabla.Rows.Add();
                        Tabla.Rows[Tabla.CurrentCell.RowIndex].Height = 40;
                        Tabla.Focus();

                    }
                }
                if (e.KeyCode == Keys.F4)
                {
                        SearchCliente buscarCliente = new SearchCliente();
                        buscarCliente.ShowDialog();

                }
            }

        }

        private void Cb_Vendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtBox_clienteId.Focus();
            }
        }
       
        
    }
}
