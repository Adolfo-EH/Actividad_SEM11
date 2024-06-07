namespace Turky_sGym_Programa
{
    partial class CORE_VENTA_PRODUCTOS
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
            this.dtgVentaProductos = new System.Windows.Forms.DataGridView();
            this.btnConsultarVentasProducto = new System.Windows.Forms.Button();
            this.cbMetodoPagoP = new System.Windows.Forms.ComboBox();
            this.lblMetodoPagoP = new System.Windows.Forms.Label();
            this.btnSalirVP = new System.Windows.Forms.Button();
            this.btnAnularVentaProducto = new System.Windows.Forms.Button();
            this.btnRegistroVProducto = new System.Windows.Forms.Button();
            this.lblFechaRegistroMostrarP = new System.Windows.Forms.Label();
            this.lblFechaRegistroP = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblPrecioAPagarP = new System.Windows.Forms.Label();
            this.cbxTipoPro = new System.Windows.Forms.ComboBox();
            this.lblTipoPlanP = new System.Windows.Forms.Label();
            this.lblVentaServicios = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cbxCantidadP = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVentaProductos
            // 
            this.dtgVentaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaProductos.Location = new System.Drawing.Point(531, 70);
            this.dtgVentaProductos.Name = "dtgVentaProductos";
            this.dtgVentaProductos.Size = new System.Drawing.Size(520, 265);
            this.dtgVentaProductos.TabIndex = 0;
            // 
            // btnConsultarVentasProducto
            // 
            this.btnConsultarVentasProducto.Location = new System.Drawing.Point(793, 355);
            this.btnConsultarVentasProducto.Name = "btnConsultarVentasProducto";
            this.btnConsultarVentasProducto.Size = new System.Drawing.Size(125, 41);
            this.btnConsultarVentasProducto.TabIndex = 38;
            this.btnConsultarVentasProducto.Text = "CONSULTAR VENTAS";
            this.btnConsultarVentasProducto.UseVisualStyleBackColor = true;
            this.btnConsultarVentasProducto.Click += new System.EventHandler(this.btnConsultarVentasProducto_Click_1);
            // 
            // cbMetodoPagoP
            // 
            this.cbMetodoPagoP.FormattingEnabled = true;
            this.cbMetodoPagoP.Location = new System.Drawing.Point(196, 231);
            this.cbMetodoPagoP.Name = "cbMetodoPagoP";
            this.cbMetodoPagoP.Size = new System.Drawing.Size(187, 21);
            this.cbMetodoPagoP.TabIndex = 37;
            // 
            // lblMetodoPagoP
            // 
            this.lblMetodoPagoP.AutoSize = true;
            this.lblMetodoPagoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPagoP.Location = new System.Drawing.Point(78, 232);
            this.lblMetodoPagoP.Name = "lblMetodoPagoP";
            this.lblMetodoPagoP.Size = new System.Drawing.Size(111, 16);
            this.lblMetodoPagoP.TabIndex = 36;
            this.lblMetodoPagoP.Text = "Método de Pago:";
            // 
            // btnSalirVP
            // 
            this.btnSalirVP.Location = new System.Drawing.Point(926, 355);
            this.btnSalirVP.Name = "btnSalirVP";
            this.btnSalirVP.Size = new System.Drawing.Size(125, 41);
            this.btnSalirVP.TabIndex = 34;
            this.btnSalirVP.Text = "SALIR";
            this.btnSalirVP.UseVisualStyleBackColor = true;
            // 
            // btnAnularVentaProducto
            // 
            this.btnAnularVentaProducto.Location = new System.Drawing.Point(662, 355);
            this.btnAnularVentaProducto.Name = "btnAnularVentaProducto";
            this.btnAnularVentaProducto.Size = new System.Drawing.Size(125, 40);
            this.btnAnularVentaProducto.TabIndex = 33;
            this.btnAnularVentaProducto.Text = "ANULAR VENTA";
            this.btnAnularVentaProducto.UseVisualStyleBackColor = true;
            this.btnAnularVentaProducto.Click += new System.EventHandler(this.btnAnularVentaProducto_Click);
            // 
            // btnRegistroVProducto
            // 
            this.btnRegistroVProducto.Location = new System.Drawing.Point(531, 354);
            this.btnRegistroVProducto.Name = "btnRegistroVProducto";
            this.btnRegistroVProducto.Size = new System.Drawing.Size(125, 41);
            this.btnRegistroVProducto.TabIndex = 32;
            this.btnRegistroVProducto.Text = "REGISTRAR VENTA";
            this.btnRegistroVProducto.UseVisualStyleBackColor = true;
            // 
            // lblFechaRegistroMostrarP
            // 
            this.lblFechaRegistroMostrarP.AutoSize = true;
            this.lblFechaRegistroMostrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistroMostrarP.Location = new System.Drawing.Point(135, 380);
            this.lblFechaRegistroMostrarP.Name = "lblFechaRegistroMostrarP";
            this.lblFechaRegistroMostrarP.Size = new System.Drawing.Size(40, 16);
            this.lblFechaRegistroMostrarP.TabIndex = 30;
            this.lblFechaRegistroMostrarP.Text = "fecha";
            // 
            // lblFechaRegistroP
            // 
            this.lblFechaRegistroP.AutoSize = true;
            this.lblFechaRegistroP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistroP.Location = new System.Drawing.Point(24, 380);
            this.lblFechaRegistroP.Name = "lblFechaRegistroP";
            this.lblFechaRegistroP.Size = new System.Drawing.Size(105, 16);
            this.lblFechaRegistroP.TabIndex = 29;
            this.lblFechaRegistroP.Text = "Fecha de Venta:";
            this.lblFechaRegistroP.Click += new System.EventHandler(this.lblFechaRegistro_Click);
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(198, 202);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(45, 16);
            this.lblPrecioProducto.TabIndex = 25;
            this.lblPrecioProducto.Text = "precio";
            // 
            // lblPrecioAPagarP
            // 
            this.lblPrecioAPagarP.AutoSize = true;
            this.lblPrecioAPagarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioAPagarP.Location = new System.Drawing.Point(88, 201);
            this.lblPrecioAPagarP.Name = "lblPrecioAPagarP";
            this.lblPrecioAPagarP.Size = new System.Drawing.Size(99, 16);
            this.lblPrecioAPagarP.TabIndex = 24;
            this.lblPrecioAPagarP.Text = "Precio a pagar:";
            // 
            // cbxTipoPro
            // 
            this.cbxTipoPro.FormattingEnabled = true;
            this.cbxTipoPro.Location = new System.Drawing.Point(196, 103);
            this.cbxTipoPro.Name = "cbxTipoPro";
            this.cbxTipoPro.Size = new System.Drawing.Size(187, 21);
            this.cbxTipoPro.TabIndex = 23;
            this.cbxTipoPro.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPlan_SelectedIndexChanged);
            // 
            // lblTipoPlanP
            // 
            this.lblTipoPlanP.AutoSize = true;
            this.lblTipoPlanP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlanP.Location = new System.Drawing.Point(73, 103);
            this.lblTipoPlanP.Name = "lblTipoPlanP";
            this.lblTipoPlanP.Size = new System.Drawing.Size(114, 16);
            this.lblTipoPlanP.TabIndex = 22;
            this.lblTipoPlanP.Text = "Tipo de Producto:";
            this.lblTipoPlanP.Click += new System.EventHandler(this.lblTipoPlan_Click);
            // 
            // lblVentaServicios
            // 
            this.lblVentaServicios.AutoSize = true;
            this.lblVentaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaServicios.Location = new System.Drawing.Point(386, 9);
            this.lblVentaServicios.Name = "lblVentaServicios";
            this.lblVentaServicios.Size = new System.Drawing.Size(302, 31);
            this.lblVentaServicios.TabIndex = 21;
            this.lblVentaServicios.Text = "VENTA PRODUCTOS";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(196, 136);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(187, 21);
            this.cbxProducto.TabIndex = 40;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(122, 137);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 16);
            this.lblProducto.TabIndex = 39;
            this.lblProducto.Text = "Producto:";
            this.lblProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxCantidadP
            // 
            this.cbxCantidadP.FormattingEnabled = true;
            this.cbxCantidadP.Location = new System.Drawing.Point(196, 170);
            this.cbxCantidadP.Name = "cbxCantidadP";
            this.cbxCantidadP.Size = new System.Drawing.Size(187, 21);
            this.cbxCantidadP.TabIndex = 42;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(122, 170);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 41;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // CORE_VENTA_PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 418);
            this.Controls.Add(this.cbxCantidadP);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnConsultarVentasProducto);
            this.Controls.Add(this.cbMetodoPagoP);
            this.Controls.Add(this.lblMetodoPagoP);
            this.Controls.Add(this.btnSalirVP);
            this.Controls.Add(this.btnAnularVentaProducto);
            this.Controls.Add(this.btnRegistroVProducto);
            this.Controls.Add(this.lblFechaRegistroMostrarP);
            this.Controls.Add(this.lblFechaRegistroP);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblPrecioAPagarP);
            this.Controls.Add(this.cbxTipoPro);
            this.Controls.Add(this.lblTipoPlanP);
            this.Controls.Add(this.lblVentaServicios);
            this.Controls.Add(this.dtgVentaProductos);
            this.Name = "CORE_VENTA_PRODUCTOS";
            this.Text = "CORE_VENTA_PRODUCTOS";
            this.Load += new System.EventHandler(this.CORE_VENTA_PRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVentaProductos;
        private System.Windows.Forms.Button btnConsultarVentasProducto;
        private System.Windows.Forms.ComboBox cbMetodoPagoP;
        private System.Windows.Forms.Label lblMetodoPagoP;
        private System.Windows.Forms.Button btnSalirVP;
        private System.Windows.Forms.Button btnAnularVentaProducto;
        private System.Windows.Forms.Button btnRegistroVProducto;
        private System.Windows.Forms.Label lblFechaRegistroMostrarP;
        private System.Windows.Forms.Label lblFechaRegistroP;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblPrecioAPagarP;
        private System.Windows.Forms.ComboBox cbxTipoPro;
        private System.Windows.Forms.Label lblTipoPlanP;
        private System.Windows.Forms.Label lblVentaServicios;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cbxCantidadP;
        private System.Windows.Forms.Label lblCantidad;
    }
}