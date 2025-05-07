using PedidoXperto.ChildClases;
using PedidoXperto.ChildForms;

namespace ProyectoXperto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadConfig();
            this.BackColor = Color.FromArgb(49, 46, 178);
            Design();
        }
        public void LoadConfig()
        {
            string filePath = GlobalSettings.Instance.PathConfig + "DB.txt"; // Ruta de tu archivo de texto
            List<string> lineas = new List<string>();

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                // Leer todas las líneas del archivo
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        GlobalSettings.Instance.Config.Add(linea);
                    }

                }
                GlobalSettings.Instance.Ip = GlobalSettings.Instance.Config[0];
                GlobalSettings.Instance.Puerto = GlobalSettings.Instance.Config[1];
                GlobalSettings.Instance.Direccion = GlobalSettings.Instance.Config[2];
                GlobalSettings.Instance.User = GlobalSettings.Instance.Config[3];
                GlobalSettings.Instance.Pw = GlobalSettings.Instance.Config[4];
                GlobalSettings.Instance.NgrokGateWay = GlobalSettings.Instance.Config[5];

                GlobalSettings.Instance.StringConnection =
                    "User=" + GlobalSettings.Instance.User + ";" +
                    "Password=" + GlobalSettings.Instance.Pw + ";" +
                    "Database=" + GlobalSettings.Instance.Direccion + ";" +
                    "DataSource=" + GlobalSettings.Instance.Ip + ";" +
                    "Port=" + GlobalSettings.Instance.Puerto + ";" +
                    "Dialect=3;" +
                    "Charset=UTF8;";
            }
            else
            {
                MessageBox.Show("Archivo de Configuracion no encontrado", "DB.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Btnpedido_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubpanelMenuPedido);
        }
        public void Design()
        {
            SubpanelMenuPedido.Visible = false;
            SubPanelMenuAdmin.Visible = false;
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
        public void HideSubmenu()
        {
            if (SubpanelMenuPedido.Visible == true)
            {
                SubpanelMenuPedido.Visible = false;
            }
            if (SubPanelMenuAdmin.Visible == true)
            {
                SubPanelMenuAdmin.Visible = false;
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (Hide.Text == ">")
            {
                Leftpanel.Width = 240;
                foreach (Control ctrl in Leftpanel.Controls)
                {
                    if (ctrl is Button && ctrl != Hide)
                        ctrl.Visible = true;
                }
                foreach (Control ctrl in SubpanelMenuPedido.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = true;
                }
                foreach (Control ctrl in SubPanelMenuAdmin.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = true;
                }
                Hide.Text = "Ocultar";
            }
            else
            {
                Leftpanel.Width = 30;
                foreach (Control ctrl in Leftpanel.Controls)
                {
                    if (ctrl is Button && ctrl != Hide)
                        ctrl.Visible = false;
                }
                foreach (Control ctrl in SubpanelMenuPedido.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }
                foreach (Control ctrl in SubPanelMenuAdmin.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }
                Hide.Text = ">";
            }
        }

        private void Btnpedido_MouseClick(object sender, MouseEventArgs e)
        {
            //Btnpedido.ForeColor = Color.FromArgb(49, 46, 178);
        }
        private void Btnpedido_MouseEnter(object sender, EventArgs e)
        {
            Btnpedido.ForeColor = Color.Beige;
            Mostrar();
        }

        private void Btnpedido_MouseLeave(object sender, EventArgs e)
        {
            Btnpedido.ForeColor = Color.White;
        }

        private void Btnpedido_MouseDown(object sender, MouseEventArgs e)
        {
            //Btnpedido.ForeColor = Color.Red;
        }

        private void Leftpanel_MouseLeave(object sender, EventArgs e)
        {
            collapseTimer.Start();
        }

        private void Leftpanel_MouseEnter(object sender, EventArgs e)
        {
            collapseTimer.Stop();

            Mostrar();
        }
        public void Ocultar()
        {
            Leftpanel.Width = 30;
            foreach (Control ctrl in Leftpanel.Controls)
            {
                if (ctrl is Button && ctrl != Hide)
                    ctrl.Visible = false;
            }
            foreach (Control ctrl in SubpanelMenuPedido.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = false;
            }
            foreach (Control ctrl in SubPanelMenuAdmin.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = false;
            }
            Hide.Text = ">";
        }
        public void Mostrar()
        {
            Leftpanel.Width = 240;
            foreach (Control ctrl in Leftpanel.Controls)
            {
                if (ctrl is Button && ctrl != Hide)
                    ctrl.Visible = true;
            }
            foreach (Control ctrl in SubpanelMenuPedido.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = true;
            }
            foreach (Control ctrl in SubPanelMenuAdmin.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = true;
            }
            Hide.Text = "Ocultar";
        }
        bool MouseEstaDentroDelPanel()
        {
            Point mousePos = PointToClient(Cursor.Position);
            Control controlBajoMouse = GetChildAtPoint(mousePos, GetChildAtPointSkip.Invisible);

            return controlBajoMouse != null && (controlBajoMouse == Leftpanel || Leftpanel.Contains(controlBajoMouse));
        }

        private void collapseTimer_Tick(object sender, EventArgs e)
        {
            // Si el mouse REALMENTE está fuera del panel y sus hijos, colapsamos
            if (!Leftpanel.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                Leftpanel.Width = 30;
                foreach (Control ctrl in Leftpanel.Controls)
                {
                    if (ctrl is Button && ctrl != Hide)
                        ctrl.Visible = false;
                }
                foreach (Control ctrl in SubpanelMenuPedido.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }
                foreach (Control ctrl in SubPanelMenuAdmin.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }
                Hide.Text = ">";
            }
            if (!MouseEstaDentroDelPanel())
            {
                Ocultar();
            }
            collapseTimer.Stop();
        }
        private Form activeForm = null;
        private void openChild(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Primarypanel.Controls.Add(childForm);
            Primarypanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private FormValidarPedido formValidarPedido;
        private void BtnValidarPedido_Click(object sender, EventArgs e)
        {
            if (formValidarPedido == null || formValidarPedido.IsDisposed)
                formValidarPedido = new FormValidarPedido();

            openChild(formValidarPedido);
            HideSubmenu();
            Ocultar();
        }
        private FormCrearPedido formCrearPedido;
        private void BtnNuevoPedido_Click(object sender, EventArgs e)
        {
            if (formCrearPedido == null || formCrearPedido.IsDisposed)
                formCrearPedido = new FormCrearPedido();

            openChild(formCrearPedido);
            HideSubmenu();
            Ocultar();
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubPanelMenuAdmin);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            openChild(new FormAdminUsuarios());
            HideSubmenu();
            Ocultar();
        }

        private void LogOut_MouseEnter(object sender, EventArgs e)
        {
            LogOut.ForeColor = System.Drawing.Color.SteelBlue;
        }

        private void LogOut_MouseLeave(object sender, EventArgs e)
        {
            LogOut.ForeColor = SystemColors.Control;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Estás seguro de que deseas cerrar sesión?\nTodo el trabajo no guardado se perderá.",
               "Confirmar cierre de sesión",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning
           );

            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        private void BtnAdministrador_MouseEnter(object sender, EventArgs e)
        {
            BtnAdministrador.ForeColor = Color.Beige;
        }

        private void BtnAdministrador_MouseLeave(object sender, EventArgs e)
        {
            BtnAdministrador.ForeColor = Color.White;
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            openChild(new FormAdminRoles());
            HideSubmenu();
            Ocultar();
        }

    }
}
