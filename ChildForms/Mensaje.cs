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

namespace PedidoXperto.ChildForms
{
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
            Btn_Aceptar.Focus();
        }
        public void SetMensaje(string mensaje, string valor)
        {
            if (valor == "ubicacion")
                LblTitulo.Text = "Ubicación";
            else if (valor == "ubicacion2")
            {
                LblTitulo.Text = "Ubicación";
                //label1.location = new point(70, 54);
            }
            else if (valor == "nota")
            {
                LblTitulo.Text = "Nota";
            }
            else if (valor == "nota2")
            {
                LblTitulo.Text = "Nota";
                //label1.location = new point(83, 54);
            }
            else if (valor == "existencia")
                LblTitulo.Text = "Existencia";
            richTextBox1.Text = mensaje;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
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

        private void LblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
