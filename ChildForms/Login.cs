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
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Spreadsheet;
using LiteDB;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Crypto.Generators;
using PedidoXperto.ChildClases;
using ProyectoXperto;

namespace PedidoXperto.ChildForms
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TxtPw.Focus();
            }
        }

        private void TxtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Acceder();
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void ForgetPw_MouseEnter(object sender, EventArgs e)
        {
            ForgetPw.ForeColor = System.Drawing.Color.SteelBlue;
            ForgetPw.Font = new System.Drawing.Font(ForgetPw.Font, FontStyle.Underline);
        }

        private void ForgetPw_MouseLeave(object sender, EventArgs e)
        {
            ForgetPw.ForeColor = System.Drawing.Color.White;
            ForgetPw.Font = new System.Drawing.Font(ForgetPw.Font, FontStyle.Regular);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        private void Acceder()
        {
            if (TxtPw.Text != string.Empty && Txt_Usuario.Text != string.Empty)
            {
                using (var db = new LiteDatabase(GlobalSettings.Instance.PathConfig + "USUARIOS_TRASPASOS.db"))
                {

                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                    // Buscar el usuario que coincida con el nombre de usuario ingresado
                    var usuario = usuarios.FindOne(x => x.UsuarioName == Txt_Usuario.Text);
                    var roles = db.GetCollection<AdminRoles>("ROLES");

                    if (usuario != null)
                    {
                        // Comprobar si la contraseña ingresada coincide con el hash almacenado
                        bool isMatch = BCrypt.Net.BCrypt.Verify(TxtPw.Text, usuario.Password);
                        
                        if (isMatch)
                        {
                            var rolActual = roles.FindOne(r => r.RolNombre == usuario.Rol);
                            this.Hide();
                            MainForm Main = new MainForm();
                            Main.BtnValidarPedido.Enabled = false;
                            Main.BtnNuevoPedido.Enabled = false;
                            Main.BtnUsuarios.Enabled = false;
                            Main.BtnRoles.Enabled = false;
                            foreach (var derecho in rolActual.Derechos)
                            {
                                if (derecho == "Validar Pedido" || derecho == "All")
                                {
                                    Main.BtnValidarPedido.Enabled = true;
                                }
                                if (derecho == "Crear Pedido" || derecho == "All")
                                {
                                    Main.BtnNuevoPedido.Enabled = true;
                                }
                                if (derecho == "Administrador de Usuarios" || derecho == "All")
                                {
                                    Main.BtnUsuarios.Enabled = true;
                                }
                                if (derecho == "Administrador de Roles" || derecho == "All")
                                {
                                    Main.BtnRoles.Enabled = true;
                                }
                            }
                            db.Dispose();
                            Main.LbUsuario.Text = "Bienvenido " + usuario.UsuarioName;
                            Main.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                            TxtPw.Focus();
                            TxtPw.Select(0, TxtPw.TextLength);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                        TxtPw.Focus();
                        TxtPw.Select(0, TxtPw.TextLength);
                    }
                }

            }
        }

    }
}
