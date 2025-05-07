namespace PedidoXperto.ChildForms
{
    partial class ChangePasswordMenu
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
            TxtPw = new TextBox();
            Txt_Usuario = new TextBox();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            Enter = new Button();
            label2 = new Label();
            label1 = new Label();
            TxtPw2 = new TextBox();
            label4 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // TxtPw
            // 
            TxtPw.CharacterCasing = CharacterCasing.Upper;
            TxtPw.Location = new Point(168, 155);
            TxtPw.Name = "TxtPw";
            TxtPw.Size = new Size(295, 23);
            TxtPw.TabIndex = 1;
            TxtPw.UseSystemPasswordChar = true;
            TxtPw.KeyDown += TxtPw_KeyDown;
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Enabled = false;
            Txt_Usuario.Location = new Point(168, 90);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(295, 23);
            Txt_Usuario.TabIndex = 0;
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
            panelTop.Size = new Size(606, 64);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(183, 0);
            label3.Name = "label3";
            label3.Size = new Size(253, 22);
            label3.TabIndex = 0;
            label3.Text = "CAMBIO DE CONTRASEÑA";
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
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(244, 271);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 3;
            Enter.Text = "Modificar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 90);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 23;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 158);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 24;
            label1.Text = "Contraseña";
            // 
            // TxtPw2
            // 
            TxtPw2.CharacterCasing = CharacterCasing.Upper;
            TxtPw2.Location = new Point(168, 224);
            TxtPw2.Name = "TxtPw2";
            TxtPw2.Size = new Size(295, 23);
            TxtPw2.TabIndex = 2;
            TxtPw2.UseSystemPasswordChar = true;
            TxtPw2.KeyDown += TxtPw2_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 227);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 26;
            label4.Text = "Confirmar Contraseña";
            // 
            // ChangePasswordMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(TxtPw2);
            Controls.Add(label4);
            Controls.Add(TxtPw);
            Controls.Add(Txt_Usuario);
            Controls.Add(panelTop);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordMenu";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPw;
        private TextBox Txt_Usuario;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Button Enter;
        private Label label2;
        private Label label1;
        private TextBox TxtPw2;
        private Label label4;
    }
}