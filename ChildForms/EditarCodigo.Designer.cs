namespace PedidoXperto.ChildForms
{
    partial class EditarCodigo
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
            label1 = new Label();
            LbRecibido = new Label();
            label3 = new Label();
            label4 = new Label();
            LbSolicitado = new Label();
            label7 = new Label();
            label2 = new Label();
            Cantidad = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LbCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)Cantidad).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 125);
            label1.Name = "label1";
            label1.Size = new Size(128, 27);
            label1.TabIndex = 0;
            label1.Text = "SOLICITADO:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbRecibido
            // 
            LbRecibido.Anchor = AnchorStyles.None;
            LbRecibido.FlatStyle = FlatStyle.Flat;
            LbRecibido.ForeColor = Color.White;
            LbRecibido.Location = new Point(327, 173);
            LbRecibido.Name = "LbRecibido";
            LbRecibido.Size = new Size(128, 25);
            LbRecibido.TabIndex = 1;
            LbRecibido.Text = "REC";
            LbRecibido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(236, 211);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 2;
            label3.Text = "CANTIDAD DESEADA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.White;
            label4.Location = new Point(431, 255);
            label4.Name = "label4";
            label4.Size = new Size(128, 33);
            label4.TabIndex = 3;
            label4.Text = "UNIDADES";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LbSolicitado
            // 
            LbSolicitado.Anchor = AnchorStyles.None;
            LbSolicitado.FlatStyle = FlatStyle.Flat;
            LbSolicitado.ForeColor = Color.White;
            LbSolicitado.Location = new Point(327, 125);
            LbSolicitado.Name = "LbSolicitado";
            LbSolicitado.Size = new Size(128, 27);
            LbSolicitado.TabIndex = 4;
            LbSolicitado.Text = "SOL";
            LbSolicitado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.FlatStyle = FlatStyle.Flat;
            label7.ForeColor = Color.White;
            label7.Location = new Point(193, 169);
            label7.Name = "label7";
            label7.Size = new Size(128, 33);
            label7.TabIndex = 6;
            label7.Text = "RECIBIDO:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 255);
            label2.Name = "label2";
            label2.Size = new Size(110, 33);
            label2.TabIndex = 7;
            label2.Text = "RECIBIDO:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Cantidad
            // 
            Cantidad.Anchor = AnchorStyles.None;
            Cantidad.Location = new Point(256, 255);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(159, 27);
            Cantidad.TabIndex = 8;
            Cantidad.KeyDown += Cantidad_KeyDown;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(LbCodigo);
            flowLayoutPanel1.Location = new Point(44, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(568, 78);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // LbCodigo
            // 
            LbCodigo.Anchor = AnchorStyles.None;
            LbCodigo.FlatStyle = FlatStyle.Flat;
            LbCodigo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCodigo.ForeColor = Color.White;
            LbCodigo.Location = new Point(3, 0);
            LbCodigo.Name = "LbCodigo";
            LbCodigo.Size = new Size(194, 25);
            LbCodigo.TabIndex = 3;
            LbCodigo.Text = "CANTIDAD DESEADA";
            LbCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditarCodigo
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(663, 338);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Cantidad);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(LbSolicitado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LbRecibido);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "EditarCodigo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarCodigo";
            ((System.ComponentModel.ISupportInitialize)Cantidad).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label LbRecibido;
        private Label label3;
        private Label label4;
        private Label LbSolicitado;
        private Label label7;
        private Label label2;
        private NumericUpDown Cantidad;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LbCodigo;
    }
}