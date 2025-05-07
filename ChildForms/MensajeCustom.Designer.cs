namespace PedidoXperto.ChildForms
{
    partial class MensajeCustom
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            GridEx = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Solicitar = new Button();
            panel1 = new Panel();
            Back = new Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridEx).BeginInit();
            panel1.SuspendLayout();
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
            panelTop.Size = new Size(1017, 81);
            panelTop.TabIndex = 16;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(320, 9);
            label3.Name = "label3";
            label3.Size = new Size(375, 25);
            label3.TabIndex = 0;
            label3.Text = "Estos articulos aun tienen existencia";
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
            Exit.Location = new Point(908, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(109, 39);
            Exit.TabIndex = 4;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // GridEx
            // 
            GridEx.AllowUserToAddRows = false;
            GridEx.AllowUserToDeleteRows = false;
            GridEx.AllowUserToResizeColumns = false;
            GridEx.AllowUserToResizeRows = false;
            GridEx.BackgroundColor = Color.FromArgb(60, 60, 60);
            GridEx.BorderStyle = BorderStyle.None;
            GridEx.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridEx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridEx.ColumnHeadersHeight = 45;
            GridEx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GridEx.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            GridEx.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GridEx.DefaultCellStyle = dataGridViewCellStyle2;
            GridEx.Dock = DockStyle.Fill;
            GridEx.EnableHeadersVisualStyles = false;
            GridEx.Location = new Point(0, 81);
            GridEx.MultiSelect = false;
            GridEx.Name = "GridEx";
            GridEx.RowHeadersVisible = false;
            GridEx.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            GridEx.RowTemplate.Height = 40;
            GridEx.Size = new Size(1017, 338);
            GridEx.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.False;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio Lista";
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.False;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.HeaderText = "Existencia";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.False;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Solicitar
            // 
            Solicitar.BackColor = SystemColors.ActiveBorder;
            Solicitar.Cursor = Cursors.Hand;
            Solicitar.Dock = DockStyle.Left;
            Solicitar.FlatAppearance.BorderSize = 0;
            Solicitar.FlatStyle = FlatStyle.Flat;
            Solicitar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            Solicitar.ForeColor = Color.Black;
            Solicitar.Location = new Point(0, 0);
            Solicitar.Name = "Solicitar";
            Solicitar.Size = new Size(504, 56);
            Solicitar.TabIndex = 20;
            Solicitar.Text = "SOLICITAR PERMISO";
            Solicitar.UseVisualStyleBackColor = false;
            Solicitar.Click += Solicitar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Back);
            panel1.Controls.Add(Solicitar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 363);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 56);
            panel1.TabIndex = 21;
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ActiveBorder;
            Back.Cursor = Cursors.Hand;
            Back.Dock = DockStyle.Left;
            Back.FlatAppearance.BorderSize = 0;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            Back.ForeColor = Color.Black;
            Back.Location = new Point(504, 0);
            Back.Name = "Back";
            Back.Size = new Size(515, 56);
            Back.TabIndex = 21;
            Back.Text = "VOLVER";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // MensajeCustom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 419);
            Controls.Add(panel1);
            Controls.Add(GridEx);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MensajeCustom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MensajeCustom";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridEx).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label label3;
        private Button Exit;
        public DataGridView GridEx;
        private Panel panel1;
        private Button Back;
        public Button Solicitar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}