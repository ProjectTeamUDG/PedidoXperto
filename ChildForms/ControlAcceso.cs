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
    public partial class ControlAcceso : Form
    {
        public delegate void EnviarVariableDelegate3();
        public event EnviarVariableDelegate3 EnviarVariableEvent3;
        public ControlAcceso()
        {
            InitializeComponent();
        }

        private void ForgetPw_Click(object sender, EventArgs e)
        {
            string existUser = null;
            if (Txt_Usuario.Text != string.Empty)
                existUser = ValidarUsuario();
            else
            {
                MessageBox.Show("Ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (existUser == null)
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChangePw changePw = new ChangePw(existUser);
            changePw.ShowDialog();
        }
        public string ValidarUsuario()
        {
            if (Txt_Usuario.Text != string.Empty)
            {
                using (var db = new LiteDatabase(GlobalSettings.Instance.PathConfig + "USUARIOS_TRASPASOS.db"))
                {

                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                    // Buscar el usuario que coincida con el nombre de usuario ingresado
                    var usuario = usuarios.FindOne(x => x.UsuarioName == Txt_Usuario.Text);  // Asegúrate de que el campo sea el nombre de usuario

                    if (usuario != null)
                    {
                        return usuario.UsuarioName;
                    }
                    else
                    {
                        return null;
                    }
                }

            }
            else
            {
                return null;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_Usuario.Text) && !string.IsNullOrWhiteSpace(TxtPw.Text))
            {
                using (var db = new LiteDatabase(@"C:\ConfigDB\USUARIOS_TRASPASOS.db"))
                {
                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");
                    var usuario = usuarios.FindOne(x => x.UsuarioName == Txt_Usuario.Text);

                    if (usuario != null)
                    {
                        bool isMatch = BCrypt.Net.BCrypt.Verify(TxtPw.Text, usuario.Password);

                        // Lista de roles permitidos
                        var rolesPermitidos = new List<string> { "INVENTARIOS", "ADMINISTRADOR", "JEFE FACTURISTA" };

                        if (isMatch)
                        {
                            if (rolesPermitidos.Contains(usuario.Rol.ToUpper()))
                            {
                                MessageBox.Show("Autorizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GlobalSettings.Instance.aceptado = true;
                                GlobalSettings.Instance.Usuario = usuario.UsuarioName;
                                EnviarVariableEvent3();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No tiene permisos suficientes.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
