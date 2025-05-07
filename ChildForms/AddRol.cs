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
using LiteDB;
using PedidoXperto.ChildClases;

namespace PedidoXperto.ChildForms
{
    public partial class AddRol : Form
    {
        public AddRol()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"C:\ConfigDB\USUARIOS_TRASPASOS.db"))
            {
                var coleccion = db.GetCollection<AdminRoles>("ROLES");

                // Validar que el nombre no esté vacío
                if (string.IsNullOrWhiteSpace(Txt_Rol.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre para el nuevo rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que no exista un rol con ese nombre
                var rolExistente = coleccion.FindOne(x => x.RolNombre == Txt_Rol.Text);
                if (rolExistente != null)
                {
                    MessageBox.Show("Ya existe un rol con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener los derechos seleccionados
                var derechos = new List<string>();
                foreach (var item in CheckList.CheckedItems)
                {
                    derechos.Add(item.ToString());
                }

                // Crear y agregar nuevo rol
                var nuevoRol = new AdminRoles
                {
                    RolNombre = Txt_Rol.Text,
                    Derechos = derechos
                };

                coleccion.Insert(nuevoRol);
                MessageBox.Show("Rol agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
