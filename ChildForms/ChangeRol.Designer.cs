﻿namespace PedidoXperto.ChildForms
{
    partial class ChangeRol
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
            Cb_Rol = new ComboBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Enabled = false;
            Txt_Usuario.Location = new Point(168, 105);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(295, 23);
            Txt_Usuario.TabIndex = 11;
            //Txt_Usuario.TextChanged += this.Txt_Usuario_TextChanged;
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
            panelTop.Size = new Size(606, 30);
            panelTop.TabIndex = 15;
            //panelTop.Paint += this.panelTop_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(223, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 22);
            label3.TabIndex = 0;
            label3.Text = "CAMBIO DE ROL";
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
            Enter.Location = new Point(244, 218);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 13;
            Enter.Text = "Modificar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 105);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Usuario";
            //label2.Click += this.label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 167);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 10;
            label1.Text = "Rol";
            // 
            // Cb_Rol
            // 
            Cb_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Rol.FormattingEnabled = true;
            Cb_Rol.Items.AddRange(new object[] { "Seleccionar Rol:", "Administrador", "Inventarios", "JefeFacturista", "Facturista" });
            Cb_Rol.Location = new Point(168, 159);
            Cb_Rol.Name = "Cb_Rol";
            Cb_Rol.Size = new Size(295, 23);
            Cb_Rol.TabIndex = 16;
            //Cb_Rol.SelectedIndexChanged += this.Cb_Rol_SelectedIndexChanged;
            // 
            // ChangeRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(Cb_Rol);
            Controls.Add(Txt_Usuario);
            Controls.Add(panelTop);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeRol";
            Text = "ChangeRol";
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
        private ComboBox Cb_Rol;
    }
}