namespace Proyecto_administración
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNombredelsistema = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCerrarSeción = new System.Windows.Forms.Button();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Blue;
            this.pnlEncabezado.Controls.Add(this.lblModulo);
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
            this.picLogo.BackColor = System.Drawing.Color.Blue;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(23, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(129, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblNombredelsistema
            // 
            this.lblNombredelsistema.AutoSize = true;
            this.lblNombredelsistema.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombredelsistema.ForeColor = System.Drawing.Color.White;
            this.lblNombredelsistema.Location = new System.Drawing.Point(247, 27);
            this.lblNombredelsistema.Name = "lblNombredelsistema";
            this.lblNombredelsistema.Size = new System.Drawing.Size(393, 40);
            this.lblNombredelsistema.TabIndex = 1;
            this.lblNombredelsistema.Text = "Ordesys-Guayo\'s Pizza";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.ForeColor = System.Drawing.Color.White;
            this.lblModulo.Location = new System.Drawing.Point(301, 88);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(271, 27);
            this.lblModulo.TabIndex = 2;
            this.lblModulo.Text = "Módulo Administración";
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInventario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(63, 203);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(236, 62);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Gestión de inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Blue;
            this.btnVentas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(536, 203);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 62);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Gestión de ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(113, 326);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(134, 55);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCerrarSeción
            // 
            this.btnCerrarSeción.BackColor = System.Drawing.Color.Red;
            this.btnCerrarSeción.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSeción.Location = new System.Drawing.Point(557, 322);
            this.btnCerrarSeción.Name = "btnCerrarSeción";
            this.btnCerrarSeción.Size = new System.Drawing.Size(151, 62);
            this.btnCerrarSeción.TabIndex = 4;
            this.btnCerrarSeción.Text = "Cerrar seción";
            this.btnCerrarSeción.UseVisualStyleBackColor = false;
            this.btnCerrarSeción.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.Blue;
            this.pnlPie.Controls.Add(this.lblUsuario);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 405);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(800, 45);
            this.pnlPie.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(12, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(228, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: Administrador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.btnCerrarSeción);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombredelsistema;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCerrarSeción;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblUsuario;
    }
}

