using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using PedidoXperto.ChildClases;

namespace PedidoXperto.ChildForms
{
    public partial class FormAdminRoles : Form
    {
        public FormAdminRoles()
        {
            InitializeComponent();
            CargarRoles();
            Design();
        }
        public void CargarRoles()
        {
            using (var db = new LiteDatabase(GlobalSettings.Instance.PathConfig + "USUARIOS_TRASPASOS.db"))
            {
                var roles = db.GetCollection<AdminRoles>("ROLES");
                // Obtener todos los usuarios de la base de datos
                var listaRoles = roles.FindAll();
                // Crear un array o lista para almacenar los nombres de usuario
                List<string> ListRol = new List<string>();
                // Llenar el array con los nombres de usuario
                foreach (var rol in listaRoles)
                {
                    //nombresArray.Add(usuario.UsuarioName);
                    TablaRoles.Rows.Add(rol.Id, rol.RolNombre);
                }

            }
        }
        public void Design()
        {
            SubpanelMenu.Visible = false;
        }
        public void HideSubmenu()
        {
            if (SubpanelMenu.Visible == true)
            {
                SubpanelMenu.Visible = false;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void BtnMen_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubpanelMenu);
        }

        private void ChangeDerechos_Click(object sender, EventArgs e)
        {
            CambiarDerechosRol cambiarRol = new CambiarDerechosRol(TablaRoles.CurrentRow.Cells[1].Value.ToString());
            cambiarRol.ShowDialog();
        }

        private void BtnEditNameRol_Click(object sender, EventArgs e)
        {
            ChangeNameRol cambiarRol = new ChangeNameRol(TablaRoles.CurrentRow.Cells[1].Value.ToString());
            cambiarRol.ShowDialog();
            TablaRoles.Rows.Clear();
            CargarRoles();
        }

        private void BtnDeleteRol_Click(object sender, EventArgs e)
        {
            string rolSeleccionado = TablaRoles.CurrentRow.Cells[1].Value.ToString();

            using (var db = new LiteDatabase(@"C:\ConfigDB\USUARIOS_TRASPASOS.db"))
            {
                var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");
                var existe = usuarios.Exists(u => u.Rol == rolSeleccionado);

                if (existe)
                {
                    MessageBox.Show("No se puede eliminar el rol porque está asignado a uno o más usuarios.", "Rol en uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var roles = db.GetCollection<AdminRoles>("ROLES");
                bool eliminado = roles.DeleteMany(r => r.RolNombre == rolSeleccionado) > 0;

                if (eliminado)
                {
                    MessageBox.Show("Rol eliminado correctamente.");
                    // Aquí podrías recargar la tabla si es necesario
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el rol (¿ya fue eliminado?).");
                }
            }
            TablaRoles.Rows.Clear();
            CargarRoles();
        }

        private void BtnAddRol_Click(object sender, EventArgs e)
        {
            AddRol agregarRol = new AddRol();
            agregarRol.ShowDialog();
            TablaRoles.Rows.Clear();
            CargarRoles();
        }

        private void SubpanelMenu_Resize(object sender, EventArgs e)
        {
            BtnAddRol.Width = SubpanelMenu.Width / 4;
            BtnDeleteRol.Width = SubpanelMenu.Width / 4;
            BtnEditNameRol.Width = SubpanelMenu.Width / 4;
            ChangeDerechos.Width = SubpanelMenu.Width / 4;

        }
    }
}
