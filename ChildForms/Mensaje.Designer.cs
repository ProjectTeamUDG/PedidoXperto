namespace PedidoXperto.ChildForms
{
    partial class Mensaje
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
            LblTitulo = new Label();
            Exit = new Button();
            Btn_Aceptar = new Button();
            richTextBox1 = new RichTextBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(LblTitulo);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(444, 63);
            panelTop.TabIndex = 15;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // LblTitulo
            // 
            LblTitulo.FlatStyle = FlatStyle.Flat;
            LblTitulo.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(149, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(144, 42);
            LblTitulo.TabIndex = 5;
            LblTitulo.Text = "label4";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            LblTitulo.MouseDown += LblTitulo_MouseDown;
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
            Exit.Location = new Point(664, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(64, 27);
            Exit.TabIndex = 4;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            // 
            // Btn_Aceptar
            // 
            Btn_Aceptar.Anchor = AnchorStyles.Top;
            Btn_Aceptar.BackColor = SystemColors.ActiveBorder;
            Btn_Aceptar.Cursor = Cursors.Hand;
            Btn_Aceptar.FlatAppearance.BorderSize = 0;
            Btn_Aceptar.FlatAppearance.MouseDownBackColor = Color.Gray;
            Btn_Aceptar.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn_Aceptar.FlatStyle = FlatStyle.Flat;
            Btn_Aceptar.ForeColor = Color.Black;
            Btn_Aceptar.Location = new Point(152, 202);
            Btn_Aceptar.Name = "Btn_Aceptar";
            Btn_Aceptar.Size = new Size(141, 50);
            Btn_Aceptar.TabIndex = 13;
            Btn_Aceptar.Text = "Aceptar";
            Btn_Aceptar.UseVisualStyleBackColor = false;
            Btn_Aceptar.Click += Btn_Aceptar_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(60, 60, 60);
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(0, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(444, 114);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // Mensaje
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(444, 274);
            Controls.Add(richTextBox1);
            Controls.Add(panelTop);
            Controls.Add(Btn_Aceptar);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Mensaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mensaje";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox Txt_Usuario;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Label ForgetPw;
        private Button Btn_Aceptar;
        private RichTextBox richTextBox1;
        private TextBox TxtPw;
        private Label label2;
        private Label label1;
        public Label LblTitulo;
    }
}