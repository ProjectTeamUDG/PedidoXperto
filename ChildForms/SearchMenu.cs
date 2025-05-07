using System.Runtime.InteropServices;
using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;
using PedidoXperto.Logic;

namespace PedidoXperto.ChildForms
{
    public partial class SearchMenu : Form
    {
        int columnIndex;
        public SearchMenu(string parametros , int ColumnIndex)
        {
            InitializeComponent();
            Txt_Nombre.Text = parametros;
            columnIndex = ColumnIndex;
            if(columnIndex == 0)
                Concepto.Text = "Clave";
            else
                Concepto.Text = "Nombre";
            CargarQuery(parametros, ColumnIndex);
        }
        public void CargarQuery(string parametros, int columnindex)
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                string[] arrayParametros = parametros.Split(' ');
                string query = $@"
                    SELECT CLAVES_ARTICULOS.CLAVE_ARTICULO, ARTICULOS.NOMBRE, PRECIOS_ARTICULOS.PRECIO  
                    FROM ARTICULOS
                    JOIN CLAVES_ARTICULOS ON CLAVES_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID
                    JOIN PRECIOS_ARTICULOS ON PRECIOS_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID
                    WHERE CLAVES_ARTICULOS.ROL_CLAVE_ART_ID = '17'
                    AND PRECIOS_ARTICULOS.PRECIO_EMPRESA_ID = '42'";

                if (columnindex == 1) 
                { 
                    foreach (string parametro in arrayParametros)
                    {
                        query += $@"AND ARTICULOS.NOMBRE LIKE '%{parametro}%' ";
                    }
                }
                if(columnindex == 0)
                {
                    foreach (string parametro in arrayParametros)
                    {
                        query += $@"AND CLAVES_ARTICULOS.CLAVE_ARTICULO LIKE '{parametro}%' ";
                    }
                    GlobalSettings.Instance.editandoclave = true;
                }
                query += ";";

                con.Open();
                FbCommand commando = new FbCommand(query, con);

                // Objeto para leer los datos obtenidos
                bool encontrado = false;
                FbDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    encontrado = true;
                    // Acceder a los valores de cada columna por su índice o nombre
                    string codigo = reader.GetString(0);
                    string nombre = reader.GetString(1);
                    string precio = reader.GetString(2);
                    string articuloid = DataBridge.GetArticuloId(codigo);
                    string Exalmacen = DataBridge.GetExistencia(articuloid, "108401");
                    string Extienda = DataBridge.GetExistencia(articuloid, "108403");
                    decimal ExistenciaTotal = decimal.Parse(Exalmacen) + decimal.Parse(Extienda);
                    Tabla.Rows.Add(codigo, nombre, decimal.Parse(precio), ExistenciaTotal);

                }
                if (!encontrado)
                    GlobalSettings.Instance.editandoclave = false;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
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

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text != string.Empty)
            {
                Tabla.Rows.Clear();
                CargarQuery(Txt_Nombre.Text,columnIndex);
                Tabla.Focus();
                Tabla.Select();
            }
        }

        private void Tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Tabla.Rows[e.RowIndex];
                GlobalSettings.Instance.Crear_clave = row.Cells[0].Value.ToString();//codigo principal
                this.Close();
            }
        }

        private void Txt_Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            Tabla.ClearSelection();
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Click(sender, e);
            }
        }

        private void Tabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Tabla.CurrentRow != null)
                {
                    if (Tabla.Rows.Count > 0)
                    {
                        GlobalSettings.Instance.Crear_clave = Tabla.CurrentRow.Cells[0].Value.ToString();//codigo principal
                        this.Close();
                    }
                }
            }

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
