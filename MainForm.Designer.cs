using PedidoXperto;

namespace ProyectoXperto
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Toppanel = new Panel();
            LogOut = new Label();
            LbUsuario = new Label();
            label1 = new Label();
            Leftpanel = new Panel();
            SubPanelMenuAdmin = new Panel();
            BtnRoles = new Button();
            BtnUsuarios = new Button();
            BtnAdministrador = new Button();
            Hide = new Button();
            SubpanelMenuPedido = new Panel();
            BtnValidarPedido = new Button();
            BtnNuevoPedido = new Button();
            Btnpedido = new Button();
            ImageMain = new PictureBox();
            collapseTimer = new System.Windows.Forms.Timer(components);
            CompletePanel = new Panel();
            Primarypanel = new Panel();
            Toppanel.SuspendLayout();
            Leftpanel.SuspendLayout();
            SubPanelMenuAdmin.SuspendLayout();
            SubpanelMenuPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageMain).BeginInit();
            CompletePanel.SuspendLayout();
            Primarypanel.SuspendLayout();
            SuspendLayout();
            // 
            // Toppanel
            // 
            Toppanel.BackColor = Color.FromArgb(60, 60, 60);
            Toppanel.Controls.Add(LogOut);
            Toppanel.Controls.Add(LbUsuario);
            Toppanel.Controls.Add(label1);
            Toppanel.Dock = DockStyle.Top;
            Toppanel.Location = new Point(0, 0);
            Toppanel.Name = "Toppanel";
            Toppanel.Size = new Size(1344, 58);
            Toppanel.TabIndex = 0;
            // 
            // LogOut
            // 
            LogOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogOut.AutoSize = true;
            LogOut.Cursor = Cursors.Hand;
            LogOut.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LogOut.ForeColor = SystemColors.Control;
            LogOut.Location = new Point(1225, 7);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(110, 21);
            LogOut.TabIndex = 2;
            LogOut.Text = "Cerrar Sesion";
            LogOut.Click += LogOut_Click;
            LogOut.MouseEnter += LogOut_MouseEnter;
            LogOut.MouseLeave += LogOut_MouseLeave;
            // 
            // LbUsuario
            // 
            LbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbUsuario.ForeColor = SystemColors.Control;
            LbUsuario.Location = new Point(985, 32);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(349, 23);
            LbUsuario.TabIndex = 1;
            LbUsuario.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(606, 3);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 0;
            label1.Text = "PedidoXperto";
            // 
            // Leftpanel
            // 
            Leftpanel.BackColor = Color.FromArgb(60, 60, 60);
            Leftpanel.Controls.Add(SubPanelMenuAdmin);
            Leftpanel.Controls.Add(BtnAdministrador);
            Leftpanel.Controls.Add(Hide);
            Leftpanel.Controls.Add(SubpanelMenuPedido);
            Leftpanel.Controls.Add(Btnpedido);
            Leftpanel.Dock = DockStyle.Left;
            Leftpanel.Location = new Point(0, 0);
            Leftpanel.Name = "Leftpanel";
            Leftpanel.Size = new Size(240, 861);
            Leftpanel.TabIndex = 1;
            Leftpanel.MouseEnter += Leftpanel_MouseEnter;
            Leftpanel.MouseLeave += Leftpanel_MouseLeave;
            // 
            // SubPanelMenuAdmin
            // 
            SubPanelMenuAdmin.Controls.Add(BtnRoles);
            SubPanelMenuAdmin.Controls.Add(BtnUsuarios);
            SubPanelMenuAdmin.Dock = DockStyle.Top;
            SubPanelMenuAdmin.Location = new Point(0, 229);
            SubPanelMenuAdmin.Name = "SubPanelMenuAdmin";
            SubPanelMenuAdmin.Size = new Size(240, 118);
            SubPanelMenuAdmin.TabIndex = 4;
            // 
            // BtnRoles
            // 
            BtnRoles.BackColor = Color.Silver;
            BtnRoles.Cursor = Cursors.Hand;
            BtnRoles.Dock = DockStyle.Top;
            BtnRoles.FlatAppearance.BorderSize = 0;
            BtnRoles.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnRoles.FlatStyle = FlatStyle.Flat;
            BtnRoles.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRoles.ForeColor = Color.Black;
            BtnRoles.Location = new Point(0, 58);
            BtnRoles.Name = "BtnRoles";
            BtnRoles.Size = new Size(240, 58);
            BtnRoles.TabIndex = 2;
            BtnRoles.Text = "Roles";
            BtnRoles.UseVisualStyleBackColor = false;
            BtnRoles.Click += BtnRoles_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.Silver;
            BtnUsuarios.Cursor = Cursors.Hand;
            BtnUsuarios.Dock = DockStyle.Top;
            BtnUsuarios.FlatAppearance.BorderSize = 0;
            BtnUsuarios.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnUsuarios.FlatStyle = FlatStyle.Flat;
            BtnUsuarios.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUsuarios.ForeColor = Color.Black;
            BtnUsuarios.Location = new Point(0, 0);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(240, 58);
            BtnUsuarios.TabIndex = 1;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnAdministrador
            // 
            BtnAdministrador.BackColor = Color.FromArgb(60, 60, 60);
            BtnAdministrador.Cursor = Cursors.Hand;
            BtnAdministrador.Dock = DockStyle.Top;
            BtnAdministrador.FlatAppearance.BorderSize = 0;
            BtnAdministrador.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnAdministrador.FlatStyle = FlatStyle.Flat;
            BtnAdministrador.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdministrador.ForeColor = SystemColors.Control;
            BtnAdministrador.Location = new Point(0, 171);
            BtnAdministrador.Name = "BtnAdministrador";
            BtnAdministrador.Size = new Size(240, 58);
            BtnAdministrador.TabIndex = 3;
            BtnAdministrador.Text = "Administrador";
            BtnAdministrador.UseVisualStyleBackColor = false;
            BtnAdministrador.Click += BtnAdministrador_Click;
            BtnAdministrador.MouseEnter += BtnAdministrador_MouseEnter;
            BtnAdministrador.MouseLeave += BtnAdministrador_MouseLeave;
            // 
            // Hide
            // 
            Hide.Cursor = Cursors.Hand;
            Hide.Dock = DockStyle.Bottom;
            Hide.FlatAppearance.BorderSize = 0;
            Hide.FlatAppearance.MouseDownBackColor = Color.White;
            Hide.FlatAppearance.MouseOverBackColor = Color.Gray;
            Hide.FlatStyle = FlatStyle.Flat;
            Hide.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hide.ForeColor = Color.White;
            Hide.Location = new Point(0, 819);
            Hide.Name = "Hide";
            Hide.Size = new Size(240, 42);
            Hide.TabIndex = 2;
            Hide.Text = "Ocultar";
            Hide.UseVisualStyleBackColor = true;
            Hide.Click += Hide_Click;
            // 
            // SubpanelMenuPedido
            // 
            SubpanelMenuPedido.Controls.Add(BtnValidarPedido);
            SubpanelMenuPedido.Controls.Add(BtnNuevoPedido);
            SubpanelMenuPedido.Dock = DockStyle.Top;
            SubpanelMenuPedido.Location = new Point(0, 58);
            SubpanelMenuPedido.Name = "SubpanelMenuPedido";
            SubpanelMenuPedido.Size = new Size(240, 113);
            SubpanelMenuPedido.TabIndex = 1;
            // 
            // BtnValidarPedido
            // 
            BtnValidarPedido.BackColor = Color.Silver;
            BtnValidarPedido.Cursor = Cursors.Hand;
            BtnValidarPedido.Dock = DockStyle.Top;
            BtnValidarPedido.FlatAppearance.BorderSize = 0;
            BtnValidarPedido.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnValidarPedido.FlatStyle = FlatStyle.Flat;
            BtnValidarPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnValidarPedido.ForeColor = Color.Black;
            BtnValidarPedido.Location = new Point(0, 58);
            BtnValidarPedido.Name = "BtnValidarPedido";
            BtnValidarPedido.Size = new Size(240, 58);
            BtnValidarPedido.TabIndex = 2;
            BtnValidarPedido.Text = "Validar Pedido";
            BtnValidarPedido.UseVisualStyleBackColor = false;
            BtnValidarPedido.Click += BtnValidarPedido_Click;
            // 
            // BtnNuevoPedido
            // 
            BtnNuevoPedido.BackColor = Color.Silver;
            BtnNuevoPedido.Cursor = Cursors.Hand;
            BtnNuevoPedido.Dock = DockStyle.Top;
            BtnNuevoPedido.FlatAppearance.BorderSize = 0;
            BtnNuevoPedido.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnNuevoPedido.FlatStyle = FlatStyle.Flat;
            BtnNuevoPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevoPedido.ForeColor = Color.Black;
            BtnNuevoPedido.Location = new Point(0, 0);
            BtnNuevoPedido.Name = "BtnNuevoPedido";
            BtnNuevoPedido.Size = new Size(240, 58);
            BtnNuevoPedido.TabIndex = 1;
            BtnNuevoPedido.Text = "Nuevo Pedido";
            BtnNuevoPedido.UseVisualStyleBackColor = false;
            BtnNuevoPedido.Click += BtnNuevoPedido_Click;
            // 
            // Btnpedido
            // 
            Btnpedido.BackColor = Color.FromArgb(60, 60, 60);
            Btnpedido.Cursor = Cursors.Hand;
            Btnpedido.Dock = DockStyle.Top;
            Btnpedido.FlatAppearance.BorderSize = 0;
            Btnpedido.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btnpedido.FlatStyle = FlatStyle.Flat;
            Btnpedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnpedido.ForeColor = SystemColors.Control;
            Btnpedido.Location = new Point(0, 0);
            Btnpedido.Name = "Btnpedido";
            Btnpedido.Size = new Size(240, 58);
            Btnpedido.TabIndex = 0;
            Btnpedido.Text = "Pedidos";
            Btnpedido.UseVisualStyleBackColor = false;
            Btnpedido.Click += Btnpedido_Click;
            Btnpedido.MouseDown += Btnpedido_MouseDown;
            Btnpedido.MouseEnter += Btnpedido_MouseEnter;
            Btnpedido.MouseLeave += Btnpedido_MouseLeave;
            // 
            // ImageMain
            // 
            ImageMain.Anchor = AnchorStyles.None;
            ImageMain.Image = ResourcesXperto.Logo;
            ImageMain.Location = new Point(466, 243);
            ImageMain.MaximumSize = new Size(466, 366);
            ImageMain.Name = "ImageMain";
            ImageMain.Size = new Size(466, 366);
            ImageMain.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageMain.TabIndex = 0;
            ImageMain.TabStop = false;
            // 
            // collapseTimer
            // 
            collapseTimer.Interval = 300;
            collapseTimer.Tick += collapseTimer_Tick;
            // 
            // CompletePanel
            // 
            CompletePanel.Controls.Add(Primarypanel);
            CompletePanel.Controls.Add(Toppanel);
            CompletePanel.Dock = DockStyle.Fill;
            CompletePanel.Location = new Point(240, 0);
            CompletePanel.Name = "CompletePanel";
            CompletePanel.Size = new Size(1344, 861);
            CompletePanel.TabIndex = 2;
            // 
            // Primarypanel
            // 
            Primarypanel.BackColor = Color.Beige;
            Primarypanel.Controls.Add(ImageMain);
            Primarypanel.Dock = DockStyle.Fill;
            Primarypanel.Location = new Point(0, 58);
            Primarypanel.Name = "Primarypanel";
            Primarypanel.Size = new Size(1344, 803);
            Primarypanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(CompletePanel);
            Controls.Add(Leftpanel);
            MinimumSize = new Size(1600, 900);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PedidoXperto";
            WindowState = FormWindowState.Maximized;
            Toppanel.ResumeLayout(false);
            Toppanel.PerformLayout();
            Leftpanel.ResumeLayout(false);
            SubPanelMenuAdmin.ResumeLayout(false);
            SubpanelMenuPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageMain).EndInit();
            CompletePanel.ResumeLayout(false);
            Primarypanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Toppanel;
        private Label label1;
        private Panel Leftpanel;
        private PictureBox ImageMain;
        private Button Btnpedido;
        private Panel SubpanelMenuPedido;
        private Button Hide;
        private System.Windows.Forms.Timer collapseTimer;
        private Button BtnAdministrador;
        private Panel SubPanelMenuAdmin;
        public Label LbUsuario;
        public Label LogOut;
        private Panel CompletePanel;
        private Panel Primarypanel;
        public Button BtnValidarPedido;
        public Button BtnNuevoPedido;
        public Button BtnUsuarios;
        public Button BtnRoles;
    }
}
