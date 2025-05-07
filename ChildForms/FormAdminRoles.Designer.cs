namespace PedidoXperto.ChildForms
{
    partial class FormAdminRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminRoles));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTop = new Panel();
            Exit = new Button();
            Titulo = new Label();
            SubpanelMenu = new Panel();
            ChangeDerechos = new Button();
            BtnEditNameRol = new Button();
            BtnDeleteRol = new Button();
            BtnAddRol = new Button();
            BtnMen = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            TablaRoles = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            SubpanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaRoles).BeginInit();
            SuspendLayout();
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
            panelTop.TabIndex = 6;
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(60, 60, 60);
            Exit.Cursor = Cursors.Hand;
            Exit.Dock = DockStyle.Right;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseOverBackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(1242, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(141, 53);
            Exit.TabIndex = 3;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Titulo
            // 
            Titulo.Dock = DockStyle.Fill;
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.Black;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1383, 53);
            Titulo.TabIndex = 4;
            Titulo.Text = "ADMINISTRADOR DE ROLES";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubpanelMenu
            // 
            SubpanelMenu.BackColor = Color.White;
            SubpanelMenu.Controls.Add(ChangeDerechos);
            SubpanelMenu.Controls.Add(BtnEditNameRol);
            SubpanelMenu.Controls.Add(BtnDeleteRol);
            SubpanelMenu.Controls.Add(BtnAddRol);
            SubpanelMenu.Dock = DockStyle.Fill;
            SubpanelMenu.Location = new Point(137, 0);
            SubpanelMenu.Name = "SubpanelMenu";
            SubpanelMenu.Size = new Size(1246, 58);
            SubpanelMenu.TabIndex = 9;
            SubpanelMenu.Resize += SubpanelMenu_Resize;
            // 
            // ChangeDerechos
            // 
            ChangeDerechos.BackColor = Color.Silver;
            ChangeDerechos.Cursor = Cursors.Hand;
            ChangeDerechos.Dock = DockStyle.Left;
            ChangeDerechos.FlatAppearance.BorderSize = 0;
            ChangeDerechos.FlatAppearance.MouseOverBackColor = Color.Gray;
            ChangeDerechos.FlatStyle = FlatStyle.Flat;
            ChangeDerechos.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ChangeDerechos.ForeColor = Color.Black;
            ChangeDerechos.Location = new Point(546, 0);
            ChangeDerechos.Name = "ChangeDerechos";
            ChangeDerechos.Size = new Size(182, 58);
            ChangeDerechos.TabIndex = 14;
            ChangeDerechos.Text = "Cambiar Derechos";
            ChangeDerechos.UseVisualStyleBackColor = false;
            ChangeDerechos.Click += ChangeDerechos_Click;
            // 
            // BtnEditNameRol
            // 
            BtnEditNameRol.BackColor = Color.Silver;
            BtnEditNameRol.Cursor = Cursors.Hand;
            BtnEditNameRol.Dock = DockStyle.Left;
            BtnEditNameRol.FlatAppearance.BorderSize = 0;
            BtnEditNameRol.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnEditNameRol.FlatStyle = FlatStyle.Flat;
            BtnEditNameRol.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnEditNameRol.ForeColor = Color.Black;
            BtnEditNameRol.Location = new Point(364, 0);
            BtnEditNameRol.Name = "BtnEditNameRol";
            BtnEditNameRol.Size = new Size(182, 58);
            BtnEditNameRol.TabIndex = 13;
            BtnEditNameRol.Text = "Editar Nombre Rol";
            BtnEditNameRol.UseVisualStyleBackColor = false;
            BtnEditNameRol.Click += BtnEditNameRol_Click;
            // 
            // BtnDeleteRol
            // 
            BtnDeleteRol.BackColor = Color.Silver;
            BtnDeleteRol.Cursor = Cursors.Hand;
            BtnDeleteRol.Dock = DockStyle.Left;
            BtnDeleteRol.FlatAppearance.BorderSize = 0;
            BtnDeleteRol.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnDeleteRol.FlatStyle = FlatStyle.Flat;
            BtnDeleteRol.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnDeleteRol.ForeColor = Color.Black;
            BtnDeleteRol.Location = new Point(182, 0);
            BtnDeleteRol.Name = "BtnDeleteRol";
            BtnDeleteRol.Size = new Size(182, 58);
            BtnDeleteRol.TabIndex = 12;
            BtnDeleteRol.Text = "Eliminar Rol";
            BtnDeleteRol.UseVisualStyleBackColor = false;
            BtnDeleteRol.Click += BtnDeleteRol_Click;
            // 
            // BtnAddRol
            // 
            BtnAddRol.BackColor = Color.Silver;
            BtnAddRol.Cursor = Cursors.Hand;
            BtnAddRol.Dock = DockStyle.Left;
            BtnAddRol.FlatAppearance.BorderSize = 0;
            BtnAddRol.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnAddRol.FlatStyle = FlatStyle.Flat;
            BtnAddRol.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnAddRol.ForeColor = Color.Black;
            BtnAddRol.Location = new Point(0, 0);
            BtnAddRol.Name = "BtnAddRol";
            BtnAddRol.Size = new Size(182, 58);
            BtnAddRol.TabIndex = 11;
            BtnAddRol.Text = "Agregar Rol";
            BtnAddRol.UseVisualStyleBackColor = false;
            BtnAddRol.Click += BtnAddRol_Click;
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
            BtnMen.Size = new Size(137, 58);
            BtnMen.TabIndex = 8;
            BtnMen.Text = "Menú";
            BtnMen.TextAlign = ContentAlignment.MiddleRight;
            BtnMen.UseVisualStyleBackColor = false;
            BtnMen.Click += BtnMen_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(SubpanelMenu);
            panel1.Controls.Add(BtnMen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 58);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(TablaRoles);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 711);
            panel2.TabIndex = 12;
            // 
            // TablaRoles
            // 
            TablaRoles.AllowUserToAddRows = false;
            TablaRoles.AllowUserToDeleteRows = false;
            TablaRoles.AllowUserToResizeColumns = false;
            TablaRoles.AllowUserToResizeRows = false;
            TablaRoles.BackgroundColor = Color.Beige;
            TablaRoles.BorderStyle = BorderStyle.None;
            TablaRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TablaRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TablaRoles.ColumnHeadersHeight = 50;
            TablaRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TablaRoles.Columns.AddRange(new DataGridViewColumn[] { Id, Column2 });
            TablaRoles.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TablaRoles.DefaultCellStyle = dataGridViewCellStyle2;
            TablaRoles.Dock = DockStyle.Fill;
            TablaRoles.EnableHeadersVisualStyles = false;
            TablaRoles.GridColor = Color.Black;
            TablaRoles.Location = new Point(0, 0);
            TablaRoles.MultiSelect = false;
            TablaRoles.Name = "TablaRoles";
            TablaRoles.ReadOnly = true;
            TablaRoles.RowHeadersVisible = false;
            TablaRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TablaRoles.RowTemplate.Height = 40;
            TablaRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaRoles.Size = new Size(1383, 711);
            TablaRoles.TabIndex = 11;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Rol";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // FormAdminRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1383, 822);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdminRoles";
            Text = "FormAdminRoles";
            panelTop.ResumeLayout(false);
            SubpanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button Exit;
        private Label Titulo;
        private Panel SubpanelMenu;
        private Button BtnAddRol;
        private Button BtnMen;
        private Button ChangeDerechos;
        private Button BtnEditNameRol;
        private Button BtnDeleteRol;
        private Panel panel1;
        private Panel panel2;
        public DataGridView TablaRoles;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column2;
    }
}