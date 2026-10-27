namespace Proyecto_administración
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNombredelsistema = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaventa = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlTotalVentas = new System.Windows.Forms.Panel();
            this.lblTextoTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodopago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTotalVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Blue;
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblNombredelsistema);
            this.pnlEncabezado.Controls.Add(this.picLogo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(800, 163);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(22, 21);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(129, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblNombredelsistema
            // 
            this.lblNombredelsistema.AutoSize = true;
            this.lblNombredelsistema.BackColor = System.Drawing.Color.Transparent;
            this.lblNombredelsistema.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombredelsistema.ForeColor = System.Drawing.Color.White;
            this.lblNombredelsistema.Location = new System.Drawing.Point(212, 33);
            this.lblNombredelsistema.Name = "lblNombredelsistema";
            this.lblNombredelsistema.Size = new System.Drawing.Size(429, 40);
            this.lblNombredelsistema.TabIndex = 1;
            this.lblNombredelsistema.Text = "OrderSys - Guayo\'s Pizza";
            this.lblNombredelsistema.Click += new System.EventHandler(this.lblNombredelsistema_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(325, 97);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 27);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gestión de ventas";
            // 
            // lblFechaventa
            // 
            this.lblFechaventa.AutoSize = true;
            this.lblFechaventa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaventa.Location = new System.Drawing.Point(12, 186);
            this.lblFechaventa.Name = "lblFechaventa";
            this.lblFechaventa.Size = new System.Drawing.Size(161, 24);
            this.lblFechaventa.TabIndex = 1;
            this.lblFechaventa.Text = "Fecha de venta:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(179, 186);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(92, 22);
            this.dtpFechaVenta.TabIndex = 2;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dtpFechaVenta_ValueChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Blue;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(389, 179);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 36);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Green;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(603, 179);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 36);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // pnlTotalVentas
            // 
            this.pnlTotalVentas.BackColor = System.Drawing.Color.MistyRose;
            this.pnlTotalVentas.Controls.Add(this.lblTotal);
            this.pnlTotalVentas.Controls.Add(this.lblTextoTotal);
            this.pnlTotalVentas.Location = new System.Drawing.Point(16, 235);
            this.pnlTotalVentas.Name = "pnlTotalVentas";
            this.pnlTotalVentas.Size = new System.Drawing.Size(198, 107);
            this.pnlTotalVentas.TabIndex = 6;
            // 
            // lblTextoTotal
            // 
            this.lblTextoTotal.AutoSize = true;
            this.lblTextoTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoTotal.Location = new System.Drawing.Point(19, 18);
            this.lblTextoTotal.Name = "lblTextoTotal";
            this.lblTextoTotal.Size = new System.Drawing.Size(155, 24);
            this.lblTextoTotal.TabIndex = 0;
            this.lblTextoTotal.Text = "Total de ventas";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(34, 53);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 44);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$ 0.00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVenta,
            this.colFecha,
            this.colTotal,
            this.colMetodopago});
            this.dataGridView1.Location = new System.Drawing.Point(246, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // colIdVenta
            // 
            this.colIdVenta.HeaderText = "ID Ventas";
            this.colIdVenta.MinimumWidth = 6;
            this.colIdVenta.Name = "colIdVenta";
            this.colIdVenta.Width = 125;
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
            this.colTotal.HeaderText = "Total($)";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 125;
            // 
            // colMetodopago
            // 
            this.colMetodopago.HeaderText = "Metodo de pago";
            this.colMetodopago.MinimumWidth = 6;
            this.colMetodopago.Name = "colMetodopago";
            this.colMetodopago.Width = 125;
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.Blue;
            this.pnlPie.Controls.Add(this.lblUsuario);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 405);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(800, 45);
            this.pnlPie.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(18, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(228, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: Administrador";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlTotalVentas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.lblFechaventa);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "FormVentas";
            this.Text = "OrderSys - Guayo\'s Pizza - Gestión de ventas";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTotalVentas.ResumeLayout(false);
            this.pnlTotalVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombredelsistema;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaventa;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlTotalVentas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTextoTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodopago;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblUsuario;
    }
}