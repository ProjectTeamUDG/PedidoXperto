namespace PedidoXperto.ChildForms
{
    partial class ChangeName
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
            label2 = new Label();
            label1 = new Label();
            Txt_Usuario2 = new TextBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Enabled = false;
            Txt_Usuario.Location = new Point(168, 140);
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
            panelTop.Size = new Size(606, 61);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(213, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 22);
            label3.TabIndex = 0;
            label3.Text = "CAMBIO DE NOMBRE";
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
            Exit.TabIndex = 3;
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
            Enter.Location = new Point(244, 253);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 2;
            Enter.Text = "Modificar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 140);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 17;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 202);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 18;
            label1.Text = "Nuevo nombre";
            label1.Click += label1_Click;
            // 
            // Txt_Usuario2
            // 
            Txt_Usuario2.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario2.Location = new Point(168, 199);
            Txt_Usuario2.Name = "Txt_Usuario2";
            Txt_Usuario2.Size = new Size(295, 23);
            Txt_Usuario2.TabIndex = 1;
            Txt_Usuario2.KeyDown += Txt_Usuario2_KeyDown;
            // 
            // ChangeName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(Txt_Usuario2);
            Controls.Add(Txt_Usuario);
            Controls.Add(panelTop);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeName";
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
        private Label label2;
        private Label label1;
        private TextBox Txt_Usuario2;
    }
}