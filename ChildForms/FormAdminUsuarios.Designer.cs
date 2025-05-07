namespace PedidoXperto.ChildForms
{
    partial class FormAdminUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Exit = new Button();
            Titulo = new Label();
            panelTop = new Panel();
            panel2 = new Panel();
            SubpanelMenu = new Panel();
            BtnChangeName = new Button();
            BtnChangePassword = new Button();
            BtnEditRol = new Button();
            BtnAddUser = new Button();
            BtnDeleteUser = new Button();
            BtnMen = new Button();
            panel1 = new Panel();
            TablaUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            SubpanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit.BackColor = Color.FromArgb(60, 60, 60);
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseOverBackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(1242, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(141, 50);
            Exit.TabIndex = 3;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.Black;
            Titulo.Location = new Point(139, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1097, 53);
            Titulo.TabIndex = 4;
            Titulo.Text = "ADMINISTRADOR DE USUARIOS";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(Exit);
            panelTop.Controls.Add(Titulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1383, 53);
            panelTop.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(SubpanelMenu);
            panel2.Controls.Add(BtnMen);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 46);
            panel2.TabIndex = 5;
            // 
            // SubpanelMenu
            // 
            SubpanelMenu.BackColor = Color.White;
            SubpanelMenu.Controls.Add(BtnChangeName);
            SubpanelMenu.Controls.Add(BtnChangePassword);
            SubpanelMenu.Controls.Add(BtnEditRol);
            SubpanelMenu.Controls.Add(BtnAddUser);
            SubpanelMenu.Controls.Add(BtnDeleteUser);
            SubpanelMenu.Dock = DockStyle.Fill;
            SubpanelMenu.Location = new Point(115, 0);
            SubpanelMenu.Name = "SubpanelMenu";
            SubpanelMenu.Size = new Size(1268, 46);
            SubpanelMenu.TabIndex = 7;
            SubpanelMenu.Paint += SubpanelMenu_Paint;
            SubpanelMenu.Resize += SubpanelMenu_Resize;
            // 
            // BtnChangeName
            // 
            BtnChangeName.BackColor = Color.Silver;
            BtnChangeName.Cursor = Cursors.Hand;
            BtnChangeName.Dock = DockStyle.Left;
            BtnChangeName.FlatAppearance.BorderSize = 0;
            BtnChangeName.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnChangeName.FlatStyle = FlatStyle.Flat;
            BtnChangeName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnChangeName.ForeColor = Color.Black;
            BtnChangeName.Location = new Point(859, 0);
            BtnChangeName.Name = "BtnChangeName";
            BtnChangeName.Size = new Size(182, 46);
            BtnChangeName.TabIndex = 11;
            BtnChangeName.Text = "Cambiar Nombre";
            BtnChangeName.UseVisualStyleBackColor = false;
            BtnChangeName.Click += BtnChangeName_Click;
            // 
            // BtnChangePassword
            // 
            BtnChangePassword.BackColor = Color.Silver;
            BtnChangePassword.Cursor = Cursors.Hand;
            BtnChangePassword.Dock = DockStyle.Left;
            BtnChangePassword.FlatAppearance.BorderSize = 0;
            BtnChangePassword.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnChangePassword.FlatStyle = FlatStyle.Flat;
            BtnChangePassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnChangePassword.ForeColor = Color.Black;
            BtnChangePassword.Location = new Point(604, 0);
            BtnChangePassword.Name = "BtnChangePassword";
            BtnChangePassword.Size = new Size(255, 46);
            BtnChangePassword.TabIndex = 12;
            BtnChangePassword.Text = "Cambiar Contraseña";
            BtnChangePassword.UseVisualStyleBackColor = false;
            BtnChangePassword.Click += BtnChangePassword_Click;
            // 
            // BtnEditRol
            // 
            BtnEditRol.BackColor = Color.Silver;
            BtnEditRol.Cursor = Cursors.Hand;
            BtnEditRol.Dock = DockStyle.Left;
            BtnEditRol.FlatAppearance.BorderSize = 0;
            BtnEditRol.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnEditRol.FlatStyle = FlatStyle.Flat;
            BtnEditRol.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnEditRol.ForeColor = Color.Black;
            BtnEditRol.Location = new Point(391, 0);
            BtnEditRol.Name = "BtnEditRol";
            BtnEditRol.Size = new Size(213, 46);
            BtnEditRol.TabIndex = 10;
            BtnEditRol.Text = "Editar Rol";
            BtnEditRol.UseVisualStyleBackColor = false;
            BtnEditRol.Click += BtnEditRol_Click;
            // 
            // BtnAddUser
            // 
            BtnAddUser.BackColor = Color.Silver;
            BtnAddUser.Cursor = Cursors.Hand;
            BtnAddUser.Dock = DockStyle.Left;
            BtnAddUser.FlatAppearance.BorderSize = 0;
            BtnAddUser.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnAddUser.FlatStyle = FlatStyle.Flat;
            BtnAddUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnAddUser.ForeColor = Color.Black;
            BtnAddUser.Location = new Point(196, 0);
            BtnAddUser.Name = "BtnAddUser";
            BtnAddUser.Size = new Size(195, 46);
            BtnAddUser.TabIndex = 8;
            BtnAddUser.Text = "Agregar Usuario";
            BtnAddUser.UseVisualStyleBackColor = false;
            BtnAddUser.Click += BtnAddUser_Click;
            // 
            // BtnDeleteUser
            // 
            BtnDeleteUser.BackColor = Color.Silver;
            BtnDeleteUser.Cursor = Cursors.Hand;
            BtnDeleteUser.Dock = DockStyle.Left;
            BtnDeleteUser.FlatAppearance.BorderSize = 0;
            BtnDeleteUser.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnDeleteUser.FlatStyle = FlatStyle.Flat;
            BtnDeleteUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnDeleteUser.ForeColor = Color.Black;
            BtnDeleteUser.Location = new Point(0, 0);
            BtnDeleteUser.Name = "BtnDeleteUser";
            BtnDeleteUser.Size = new Size(196, 46);
            BtnDeleteUser.TabIndex = 9;
            BtnDeleteUser.Text = "Eliminar Usuario";
            BtnDeleteUser.UseVisualStyleBackColor = false;
            BtnDeleteUser.Click += BtnDeleteUser_Click;
            BtnDeleteUser.MouseEnter += BtnDeleteUser_MouseEnter;
            // 
            // BtnMen
            // 
            BtnMen.BackColor = Color.Silver;
            BtnMen.Cursor = Cursors.Hand;
            BtnMen.Dock = DockStyle.Left;
            BtnMen.FlatAppearance.BorderSize = 0;
            BtnMen.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMen.FlatStyle = FlatStyle.Flat;
            BtnMen.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnMen.ForeColor = Color.Black;
            BtnMen.Image = (Image)resources.GetObject("BtnMen.Image");
            BtnMen.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMen.Location = new Point(0, 0);
            BtnMen.Name = "BtnMen";
            BtnMen.Size = new Size(115, 46);
            BtnMen.TabIndex = 6;
            BtnMen.Text = "Menú";
            BtnMen.TextAlign = ContentAlignment.MiddleRight;
            BtnMen.UseVisualStyleBackColor = false;
            BtnMen.Click += BtnMen_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TablaUsuarios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 723);
            panel1.TabIndex = 6;
            // 
            // TablaUsuarios
            // 
            TablaUsuarios.AllowUserToAddRows = false;
            TablaUsuarios.AllowUserToDeleteRows = false;
            TablaUsuarios.AllowUserToResizeColumns = false;
            TablaUsuarios.AllowUserToResizeRows = false;
            TablaUsuarios.BackgroundColor = Color.Beige;
            TablaUsuarios.BorderStyle = BorderStyle.None;
            TablaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TablaUsuarios.ColumnHeadersHeight = 50;
            TablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TablaUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Column1, Column2 });
            TablaUsuarios.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TablaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            TablaUsuarios.Dock = DockStyle.Fill;
            TablaUsuarios.EnableHeadersVisualStyles = false;
            TablaUsuarios.GridColor = Color.Black;
            TablaUsuarios.Location = new Point(0, 0);
            TablaUsuarios.MultiSelect = false;
            TablaUsuarios.Name = "TablaUsuarios";
            TablaUsuarios.ReadOnly = true;
            TablaUsuarios.RowHeadersVisible = false;
            TablaUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TablaUsuarios.RowTemplate.Height = 40;
            TablaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaUsuarios.Size = new Size(1383, 723);
            TablaUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Usuario";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Rol";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // FormAdminUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 822);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdminUsuarios";
            Text = "FormAdminUsuarios";
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            SubpanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Exit;
        private Label Titulo;
        private Panel panelTop;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button BtnMen;
        private Button BtnAddUser;
        private Button BtnChangePassword;
        private Button BtnChangeName;
        private Button BtnEditRol;
        private Button BtnDeleteUser;
        private Panel SubpanelMenu;
        public DataGridView TablaUsuarios;
    }
}