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
    public partial class FormAdminUsuarios : Form
    {
        public FormAdminUsuarios()
        {
            InitializeComponent();
            CargarUsers();
            Design();
        }
        public void CargarUsers()
        {
            using (var db = new LiteDatabase(GlobalSettings.Instance.PathConfig + "USUARIOS_TRASPASOS.db"))
            {
                var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");
                // Obtener todos los usuarios de la base de datos
                var listaUsuarios = usuarios.FindAll();
                // Crear un array o lista para almacenar los nombres de usuario
                // Llenar el array con los nombres de usuario
                foreach (var usuario in listaUsuarios)
                {
                    //nombresArray.Add(usuario.UsuarioName);
                    TablaUsuarios.Rows.Add(usuario.Id, usuario.UsuarioName, usuario.Rol);
                }

            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void SubpanelMenu_Resize(object sender, EventArgs e)
        {
            BtnAddUser.Width = SubpanelMenu.Width / 5;
            BtnChangeName.Width = SubpanelMenu.Width / 5;
            BtnDeleteUser.Width = SubpanelMenu.Width / 5;
            BtnEditRol.Width = SubpanelMenu.Width / 5;
            BtnChangePassword.Width = SubpanelMenu.Width / 5;
        }

        private void BtnDeleteUser_MouseEnter(object sender, EventArgs e)
        {
            //BtnDeleteUser.ForeColor = System.Drawing.Color.White;
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (TablaUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el Id del usuario desde la fila seleccionada
                int userId = Convert.ToInt32(TablaUsuarios.SelectedRows[0].Cells[0].Value);  // Suponiendo que la columna 0 contiene el Id

                // Confirmar si realmente quiere eliminar el usuario
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Conectar a la base de datos y eliminar el usuario
                    using (var db = new LiteDatabase("C:\\ConfigDB\\USUARIOS_TRASPASOS.db"))
                    {
                        var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                        // Buscar el usuario en la base de datos por su ID
                        var usuarioAEliminar = usuarios.FindOne(u => u.Id == userId);

                        if (usuarioAEliminar != null)
                        {
                            // Eliminar el usuario de la base de datos
                            usuarios.Delete(usuarioAEliminar.Id);
                            MessageBox.Show("Usuario eliminado exitosamente.");

                            // Eliminar la fila del DataGridView
                            TablaUsuarios.Rows.RemoveAt(TablaUsuarios.SelectedRows[0].Index);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario en la base de datos.");
                        }
                    }
                    TablaUsuarios.Rows.Clear();
                    CargarUsers();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUser agregarUsuario = new AddUser();
            agregarUsuario.ShowDialog();
            TablaUsuarios.Rows.Clear();
            CargarUsers();
        }

        private void BtnEditRol_Click(object sender, EventArgs e)
        {
            ChangeUserRol editarRol = new ChangeUserRol(TablaUsuarios.CurrentRow.Cells[1].Value.ToString());
            editarRol.ShowDialog();
            TablaUsuarios.Rows.Clear();
            CargarUsers();
        }

        private void BtnChangeName_Click(object sender, EventArgs e)
        {
            ChangeName changeName = new ChangeName(TablaUsuarios.CurrentRow.Cells[1].Value.ToString());
            changeName.ShowDialog();
            TablaUsuarios.Rows.Clear();
            CargarUsers();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordMenu changePW = new ChangePasswordMenu(TablaUsuarios.CurrentRow.Cells[1].Value.ToString());
            changePW.ShowDialog();
            TablaUsuarios.Rows.Clear();
            CargarUsers();
        }

        private void SubpanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
