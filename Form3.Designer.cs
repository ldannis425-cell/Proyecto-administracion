namespace Proyecto_administración
{
    partial class FormReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblNombresistema = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreporteventas = new System.Windows.Forms.Button();
            this.btnProductoregistado = new System.Windows.Forms.Button();
            this.btnVentasperiodo = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTextoTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.colIDventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Blue;
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblNombresistema);
            this.pnlEncabezado.Controls.Add(this.pictureBox1);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(800, 163);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(233, 188);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(73, 23);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Click += new System.EventHandler(this.lblDesde_Click);
            // 
            // lblNombresistema
            // 
            this.lblNombresistema.AutoSize = true;
            this.lblNombresistema.BackColor = System.Drawing.Color.Transparent;
            this.lblNombresistema.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresistema.ForeColor = System.Drawing.Color.White;
            this.lblNombresistema.Location = new System.Drawing.Point(239, 35);
            this.lblNombresistema.Name = "lblNombresistema";
            this.lblNombresistema.Size = new System.Drawing.Size(429, 40);
            this.lblNombresistema.TabIndex = 1;
            this.lblNombresistema.Text = "OrderSys - Guayo\'s Pizza";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(384, 94);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 27);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Reporte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnVentasperiodo);
            this.panel1.Controls.Add(this.btnreporteventas);
            this.panel1.Controls.Add(this.btnProductoregistado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 287);
            this.panel1.TabIndex = 2;
            // 
            // btnreporteventas
            // 
            this.btnreporteventas.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporteventas.Location = new System.Drawing.Point(12, 52);
            this.btnreporteventas.Name = "btnreporteventas";
            this.btnreporteventas.Size = new System.Drawing.Size(192, 36);
            this.btnreporteventas.TabIndex = 0;
            this.btnreporteventas.Text = "Reporte de ventas";
            this.btnreporteventas.UseVisualStyleBackColor = true;
            // 
            // btnProductoregistado
            // 
            this.btnProductoregistado.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoregistado.Location = new System.Drawing.Point(8, 134);
            this.btnProductoregistado.Name = "btnProductoregistado";
            this.btnProductoregistado.Size = new System.Drawing.Size(201, 28);
            this.btnProductoregistado.TabIndex = 3;
            this.btnProductoregistado.Text = "Producto registrado";
            this.btnProductoregistado.UseVisualStyleBackColor = true;
            // 
            // btnVentasperiodo
            // 
            this.btnVentasperiodo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasperiodo.Location = new System.Drawing.Point(8, 217);
            this.btnVentasperiodo.Name = "btnVentasperiodo";
            this.btnVentasperiodo.Size = new System.Drawing.Size(203, 38);
            this.btnVentasperiodo.TabIndex = 4;
            this.btnVentasperiodo.Text = "Total de ventas por periodo";
            this.btnVentasperiodo.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(428, 189);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(67, 23);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(303, 189);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(93, 22);
            this.dtpDesde.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(492, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Blue;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(617, 181);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(171, 38);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblTextoTotal);
            this.panel2.Location = new System.Drawing.Point(237, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 84);
            this.panel2.TabIndex = 7;
            // 
            // lblTextoTotal
            // 
            this.lblTextoTotal.AutoSize = true;
            this.lblTextoTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoTotal.Location = new System.Drawing.Point(99, 9);
            this.lblTextoTotal.Name = "lblTextoTotal";
            this.lblTextoTotal.Size = new System.Drawing.Size(332, 27);
            this.lblTextoTotal.TabIndex = 0;
            this.lblTextoTotal.Text = "Total de ventas en el periodo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(208, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 33);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$ 0.00";
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDventa,
            this.colFecha,
            this.colTotal,
            this.colMetodoPago});
            this.dgvVentas.Location = new System.Drawing.Point(237, 325);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(551, 113);
            this.dgvVentas.TabIndex = 8;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // colIDventa
            // 
            this.colIDventa.HeaderText = "ID Venta";
            this.colIDventa.MinimumWidth = 6;
            this.colIDventa.Name = "colIDventa";
            this.colIDventa.Width = 125;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 125;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total ($)";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 125;
            // 
            // colMetodoPago
            // 
            this.colMetodoPago.HeaderText = "Método de pago";
            this.colMetodoPago.MinimumWidth = 6;
            this.colMetodoPago.Name = "colMetodoPago";
            this.colMetodoPago.Width = 125;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "FormReportes";
            this.Text = "OrderSys - Guayo\'s Pizza - Reportes";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombresistema;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreporteventas;
        private System.Windows.Forms.Button btnProductoregistado;
        private System.Windows.Forms.Button btnVentasperiodo;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTextoTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
    }
}