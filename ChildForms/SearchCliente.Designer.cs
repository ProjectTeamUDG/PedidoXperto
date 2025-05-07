namespace PedidoXperto.ChildForms
{
    partial class SearchCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            TxtNombre = new TextBox();
            Buscar = new Button();
            Concepto = new Label();
            panel1 = new Panel();
            TablaClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaClientes).BeginInit();
            SuspendLayout();
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
            panelTop.Size = new Size(676, 44);
            panelTop.TabIndex = 16;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(236, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 22);
            label3.TabIndex = 0;
            label3.Text = "BUSCAR ARTICULO";
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
            Exit.Location = new Point(612, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(64, 30);
            Exit.TabIndex = 4;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.CharacterCasing = CharacterCasing.Upper;
            TxtNombre.Font = new Font("Century Gothic", 12F);
            TxtNombre.Location = new Point(141, 21);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(365, 27);
            TxtNombre.TabIndex = 18;
            TxtNombre.KeyDown += TxtNombre_KeyDown;
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top;
            Buscar.BackColor = SystemColors.ActiveBorder;
            Buscar.Cursor = Cursors.Hand;
            Buscar.FlatAppearance.BorderSize = 0;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Century Gothic", 12F);
            Buscar.ForeColor = Color.Black;
            Buscar.Location = new Point(542, 17);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(87, 28);
            Buscar.TabIndex = 19;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += Buscar_Click;
            // 
            // Concepto
            // 
            Concepto.AutoSize = true;
            Concepto.BackColor = Color.FromArgb(60, 60, 60);
            Concepto.Font = new Font("Century Gothic", 12F);
            Concepto.ForeColor = Color.White;
            Concepto.Location = new Point(47, 21);
            Concepto.Name = "Concepto";
            Concepto.Size = new Size(73, 21);
            Concepto.TabIndex = 17;
            Concepto.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtNombre);
            panel1.Controls.Add(Buscar);
            panel1.Controls.Add(Concepto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 77);
            panel1.TabIndex = 20;
            // 
            // TablaClientes
            // 
            TablaClientes.AllowUserToAddRows = false;
            TablaClientes.AllowUserToDeleteRows = false;
            TablaClientes.BackgroundColor = Color.FromArgb(60, 60, 60);
            TablaClientes.BorderStyle = BorderStyle.None;
            TablaClientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TablaClientes.ColumnHeadersHeight = 30;
            TablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TablaClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            TablaClientes.Dock = DockStyle.Fill;
            TablaClientes.EnableHeadersVisualStyles = false;
            TablaClientes.Location = new Point(0, 121);
            TablaClientes.Margin = new Padding(4);
            TablaClientes.MultiSelect = false;
            TablaClientes.Name = "TablaClientes";
            TablaClientes.ReadOnly = true;
            TablaClientes.RowHeadersVisible = false;
            TablaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaClientes.Size = new Size(676, 213);
            TablaClientes.TabIndex = 21;
            TablaClientes.KeyDown += TablaClientes_KeyDown;
            // 
            // Column1
            // 
            Column1.HeaderText = "Clave";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descuento";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // SearchCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(676, 334);
            Controls.Add(TablaClientes);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SearchCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchCliente";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TablaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        public TextBox TxtNombre;
        private Label Concepto;
        private Panel panel1;
        public DataGridView TablaClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        public Button Buscar;
    }
}