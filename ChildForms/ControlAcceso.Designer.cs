namespace PedidoXperto.ChildForms
{
    partial class ControlAcceso
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
            ForgetPw = new Label();
            Enter = new Button();
            TxtPw = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Font = new Font("Century Gothic", 11.25F);
            Txt_Usuario.Location = new Point(168, 105);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(295, 26);
            Txt_Usuario.TabIndex = 11;
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
            label3.Location = new Point(244, 19);
            label3.Name = "label3";
            label3.Size = new Size(120, 24);
            label3.TabIndex = 0;
            label3.Text = "AUTORIZAR";
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
            // ForgetPw
            // 
            ForgetPw.AutoSize = true;
            ForgetPw.Cursor = Cursors.Hand;
            ForgetPw.Font = new Font("Century Gothic", 11.25F);
            ForgetPw.ForeColor = Color.White;
            ForgetPw.Location = new Point(230, 210);
            ForgetPw.Name = "ForgetPw";
            ForgetPw.Size = new Size(166, 20);
            ForgetPw.TabIndex = 14;
            ForgetPw.Text = "Olvidé mi contraseña";
            ForgetPw.Click += ForgetPw_Click;
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
            Enter.Font = new Font("Century Gothic", 11.25F);
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(244, 276);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 13;
            Enter.Text = "Autorizar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // TxtPw
            // 
            TxtPw.Font = new Font("Century Gothic", 11.25F);
            TxtPw.Location = new Point(168, 167);
            TxtPw.Name = "TxtPw";
            TxtPw.Size = new Size(295, 26);
            TxtPw.TabIndex = 12;
            TxtPw.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 105);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 9;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 167);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 10;
            label1.Text = "Contraseña";
            // 
            // ControlAcceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(Txt_Usuario);
            Controls.Add(panelTop);
            Controls.Add(ForgetPw);
            Controls.Add(Enter);
            Controls.Add(TxtPw);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ControlAcceso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControlAcceso";
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
        private Label ForgetPw;
        private Button Enter;
        private TextBox TxtPw;
        private Label label2;
        private Label label1;
    }
}