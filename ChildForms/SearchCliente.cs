using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;

namespace PedidoXperto.ChildForms
{
    public partial class SearchCliente : Form
    {
        public SearchCliente()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Buscar_Click(object sender, EventArgs e)
        {
            TablaClientes.Rows.Clear();
            if (TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingrese un nombre", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
                try
                {
                    con.Open();
                    string nombreBuscado = TxtNombre.Text;
                    string[] palabras = nombreBuscado.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string query = @"
                    SELECT DIRS_CLIENTES.NOMBRE_CONSIG, CLAVES_CLIENTES.CLAVE_CLIENTE, POLITICAS_DSCTOS_ART_CLI.DESCUENTO 
                    FROM DIRS_CLIENTES
                    JOIN CLAVES_CLIENTES ON CLAVES_CLIENTES.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID
                    JOIN PRECIOS_CLI_CLI ON PRECIOS_CLI_CLI.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID
                    JOIN POLITICAS_DSCTOS_ART_CLI ON POLITICAS_DSCTOS_ART_CLI.POLITICA_DSCTO_ART_CLI_ID = PRECIOS_CLI_CLI.POLITICA_DSCTO_ART_CLI_ID
                    WHERE ";

                    List<string> condiciones = new List<string>();
                    foreach (string palabra in palabras)
                    {
                        condiciones.Add("DIRS_CLIENTES.NOMBRE_CONSIG LIKE '%" + palabra + "%'");
                    }

                    query += string.Join(" AND ", condiciones);

                    FbCommand command = new FbCommand(query, con);
                    FbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string clave = reader.GetString(1);
                        string nombre = reader.GetString(0);
                        string descuento = reader.GetString(2);
                        TablaClientes.Rows.Add(clave, nombre, descuento);
                    }

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
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Click(sender, e);
            }
        }

        private void TablaClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (TablaClientes.RowCount > 0 && e.KeyCode == Keys.Enter)
            {
                // Assuming you want to select the row that is currently focused/selected
                if (TablaClientes.CurrentRow != null)
                {
                    DataGridViewRow row = TablaClientes.CurrentRow;
                    CrearCliente nuevocliente = new CrearCliente(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());

                    //GlobalSettings.Instance.Crear_clave = row.Cells[0].Value.ToString();
                    //GlobalSettings.Instance.Crear_Nombre = row.Cells[1].Value.ToString();
                    this.Close();
                }
            }
        }
        public class CrearCliente
        {
            public static string Clave { get; set; }
            public static string Nombre { get; set; }
            public static string Descuento { get; set; }
            public CrearCliente(string clave, string nombre, string descuento)
            {
                Clave = clave;
                Nombre = nombre;
                Descuento = descuento;
            }
        }
    }
}
