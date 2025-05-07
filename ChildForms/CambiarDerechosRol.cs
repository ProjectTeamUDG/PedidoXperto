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
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using LiteDB;
using PedidoXperto.ChildClases;

namespace PedidoXperto.ChildForms
{
    public partial class CambiarDerechosRol : Form
    {
        public CambiarDerechosRol(string Rol)
        {
            InitializeComponent();
            Txt_Rol.Text = Rol;
            Cargar();
        }
        public void Cargar()
        {

            using (var db = new LiteDatabase(@"C:\ConfigDB\USUARIOS_TRASPASOS.db"))
            {
                var coleccion = db.GetCollection<AdminRoles>("ROLES");
                var rol = coleccion.FindOne(x => x.RolNombre == Txt_Rol.Text);

                if (rol != null)
                {
                    // Recorre los items del CheckedListBox y marca si están en la lista de derechos
                    for (int i = 0; i < CheckList.Items.Count; i++)
                    {
                        string derecho = CheckList.Items[i].ToString();
                        CheckList.SetItemChecked(i, rol.Derechos.Contains(derecho));
                    }
                }
            }
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"C:\ConfigDB\USUARIOS_TRASPASOS.db"))
            {
                var coleccion = db.GetCollection<AdminRoles>("ROLES");
                var rol = coleccion.FindOne(x => x.RolNombre == Txt_Rol.Text);

                if (rol != null)
                {
                    // Obtener los derechos seleccionados
                    var nuevosDerechos = new List<string>();
                    foreach (var item in CheckList.CheckedItems)
                    {
                        nuevosDerechos.Add(item.ToString());
                    }

                    // Asignar y actualizar
                    rol.Derechos = nuevosDerechos;
                    coleccion.Update(rol);

                    MessageBox.Show("Derechos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rol no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
