namespace PedidoXperto.ChildForms
{
    partial class AddUser
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
            Txt_Usuario = new TextBox();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            Enter = new Button();
            TxtPw = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Rol = new Label();
            Cb_Rol = new ComboBox();
            TxtPw2 = new TextBox();
            label4 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Location = new Point(168, 60);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(295, 23);
            Txt_Usuario.TabIndex = 1;
            Txt_Usuario.KeyDown += Txt_Usuario_KeyDown;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(60, 60, 60);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(606, 44);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(218, 2);
            label3.Name = "label3";
            label3.Size = new Size(197, 22);
            label3.TabIndex = 0;
            label3.Text = "REGISTRAR USUARIO";
            label3.MouseDown += label3_MouseDown;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top;
            Exit.BackColor = SystemColors.ActiveBorder;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Location = new Point(542, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(64, 27);
            Exit.TabIndex = 6;
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
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(232, 246);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 5;
            Enter.Text = "Ingresar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // TxtPw
            // 
            TxtPw.Location = new Point(168, 107);
            TxtPw.Name = "TxtPw";
            TxtPw.Size = new Size(295, 23);
            TxtPw.TabIndex = 2;
            TxtPw.UseSystemPasswordChar = true;
            TxtPw.KeyDown += TxtPw_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 63);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 110);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.ForeColor = Color.White;
            Rol.Location = new Point(56, 213);
            Rol.Name = "Rol";
            Rol.Size = new Size(24, 15);
            Rol.TabIndex = 0;
            Rol.Text = "Rol";
            // 
            // Cb_Rol
            // 
            Cb_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Rol.FormattingEnabled = true;
            Cb_Rol.Items.AddRange(new object[] { "Seleccionar Rol:", "Administrador", "Inventarios", "JefeFacturista", "Facturista" });
            Cb_Rol.Location = new Point(168, 205);
            Cb_Rol.Name = "Cb_Rol";
            Cb_Rol.Size = new Size(295, 23);
            Cb_Rol.TabIndex = 4;
            Cb_Rol.KeyDown += Cb_Rol_KeyDown;
            // 
            // TxtPw2
            // 
            TxtPw2.Location = new Point(168, 157);
            TxtPw2.Name = "TxtPw2";
            TxtPw2.Size = new Size(295, 23);
            TxtPw2.TabIndex = 3;
            TxtPw2.UseSystemPasswordChar = true;
            TxtPw2.KeyDown += TxtPw2_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 160);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Confirmar";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 308);
            Controls.Add(TxtPw2);
            Controls.Add(label4);
            Controls.Add(Cb_Rol);
            Controls.Add(Rol);
            Controls.Add(Txt_Usuario);
            Controls.Add(panelTop);
            Controls.Add(Enter);
            Controls.Add(TxtPw);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Usuario;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Button Enter;
        private TextBox TxtPw;
        private Label label2;
        private Label label1;
        private Label Rol;
        private ComboBox Cb_Rol;
        private TextBox TxtPw2;
        private Label label4;
    }
}