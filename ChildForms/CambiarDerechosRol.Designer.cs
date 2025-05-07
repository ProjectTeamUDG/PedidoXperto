namespace PedidoXperto.ChildForms
{
    partial class CambiarDerechosRol
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
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            Enter = new Button();
            label2 = new Label();
            Txt_Rol = new TextBox();
            CheckList = new CheckedListBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(606, 63);
            panelTop.TabIndex = 15;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(233, 9);
            label3.Name = "label3";
            label3.Size = new Size(176, 24);
            label3.TabIndex = 0;
            label3.Text = "CAMBIO DE ROL";
            label3.MouseDown += label3_MouseDown;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top;
            Exit.BackColor = SystemColors.ActiveBorder;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Gray;
            Exit.FlatAppearance.MouseOverBackColor = Color.Gray;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Location = new Point(542, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(64, 27);
            Exit.TabIndex = 4;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top;
            Enter.BackColor = SystemColors.ActiveBorder;
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatAppearance.MouseDownBackColor = Color.Gray;
            Enter.FlatAppearance.MouseOverBackColor = Color.Gray;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(233, 282);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 42);
            Enter.TabIndex = 13;
            Enter.Text = "Cambiar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 105);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 9;
            label2.Text = "Rol";
            // 
            // Txt_Rol
            // 
            Txt_Rol.Enabled = false;
            Txt_Rol.Location = new Point(168, 105);
            Txt_Rol.Name = "Txt_Rol";
            Txt_Rol.Size = new Size(295, 27);
            Txt_Rol.TabIndex = 11;
            Txt_Rol.TextAlign = HorizontalAlignment.Center;
            // 
            // CheckList
            // 
            CheckList.BackColor = Color.FromArgb(60, 60, 60);
            CheckList.BorderStyle = BorderStyle.None;
            CheckList.CheckOnClick = true;
            CheckList.Cursor = Cursors.Hand;
            CheckList.ForeColor = Color.White;
            CheckList.FormattingEnabled = true;
            CheckList.Items.AddRange(new object[] { "Crear Pedido", "Validar Pedido", "Administrador de Usuarios", "Administrador de Roles" });
            CheckList.Location = new Point(168, 158);
            CheckList.Name = "CheckList";
            CheckList.SelectionMode = SelectionMode.None;
            CheckList.Size = new Size(295, 88);
            CheckList.TabIndex = 16;
            // 
            // CambiarDerechosRol
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(CheckList);
            Controls.Add(Txt_Rol);
            Controls.Add(panelTop);
            Controls.Add(Enter);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CambiarDerechosRol";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "CambiarRol";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Button Enter;
        private Label label2;
        public CheckedListBox CheckList;
        public TextBox Txt_Rol;
    }
}