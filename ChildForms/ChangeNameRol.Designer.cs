namespace PedidoXperto.ChildForms
{
    partial class ChangeNameRol
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
            Txt_Rol2 = new TextBox();
            Txt_Rol = new TextBox();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            Enter = new Button();
            label2 = new Label();
            label1 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Rol2
            // 
            Txt_Rol2.CharacterCasing = CharacterCasing.Upper;
            Txt_Rol2.Location = new Point(168, 169);
            Txt_Rol2.Name = "Txt_Rol2";
            Txt_Rol2.Size = new Size(295, 27);
            Txt_Rol2.TabIndex = 21;
            // 
            // Txt_Rol
            // 
            Txt_Rol.Enabled = false;
            Txt_Rol.Location = new Point(168, 100);
            Txt_Rol.Name = "Txt_Rol";
            Txt_Rol.Size = new Size(295, 27);
            Txt_Rol.TabIndex = 19;
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
            panelTop.Size = new Size(606, 71);
            panelTop.TabIndex = 20;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(168, 5);
            label3.Name = "label3";
            label3.Size = new Size(277, 22);
            label3.TabIndex = 0;
            label3.Text = "CAMBIO DE NOMBRE DE ROL";
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
            Enter.Location = new Point(244, 271);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 22;
            Enter.Text = "Modificar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 23;
            label2.Text = "Nombre Rol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 172);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 24;
            label1.Text = "Nuevo nombre";
            // 
            // ChangeNameRol
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(Txt_Rol2);
            Controls.Add(Txt_Rol);
            Controls.Add(panelTop);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ChangeNameRol";
            Text = "ChangeNameRol";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Rol2;
        private TextBox Txt_Rol;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Button Enter;
        private Label label2;
        private Label label1;
    }
}