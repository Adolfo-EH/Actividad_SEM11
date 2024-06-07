namespace Turky_sGym_Programa
{
    partial class CORE_VENTA_SERVICIOS
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
            this.lblVentaServicios = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.cbxTipoPlan = new System.Windows.Forms.ComboBox();
            this.lblPrecioAPagar = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.txbDNICliente = new System.Windows.Forms.TextBox();
            this.lblNombreCompletoCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbEdadCliente = new System.Windows.Forms.TextBox();
            this.txbTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txbDNI_Cliente = new System.Windows.Forms.TextBox();
            this.txbNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblFechaRegistroMostrar = new System.Windows.Forms.Label();
            this.btnEditarFecha = new System.Windows.Forms.Button();
            this.btnRegistroServicio = new System.Windows.Forms.Button();
            this.btnAnularVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVentaServicios
            // 
            this.lblVentaServicios.AutoSize = true;
            this.lblVentaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaServicios.Location = new System.Drawing.Point(49, 9);
            this.lblVentaServicios.Name = "lblVentaServicios";
            this.lblVentaServicios.Size = new System.Drawing.Size(103, 13);
            this.lblVentaServicios.TabIndex = 0;
            this.lblVentaServicios.Text = "VENTA SERVICIOS";
            this.lblVentaServicios.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.Location = new System.Drawing.Point(125, 220);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(87, 16);
            this.lblTipoPlan.TabIndex = 2;
            this.lblTipoPlan.Text = "Tipo de plan:";
            this.lblTipoPlan.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbxTipoPlan
            // 
            this.cbxTipoPlan.FormattingEnabled = true;
            this.cbxTipoPlan.Location = new System.Drawing.Point(217, 219);
            this.cbxTipoPlan.Name = "cbxTipoPlan";
            this.cbxTipoPlan.Size = new System.Drawing.Size(187, 21);
            this.cbxTipoPlan.TabIndex = 3;
            this.cbxTipoPlan.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPlan_SelectedIndexChanged_1);
            // 
            // lblPrecioAPagar
            // 
            this.lblPrecioAPagar.AutoSize = true;
            this.lblPrecioAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioAPagar.Location = new System.Drawing.Point(112, 252);
            this.lblPrecioAPagar.Name = "lblPrecioAPagar";
            this.lblPrecioAPagar.Size = new System.Drawing.Size(100, 16);
            this.lblPrecioAPagar.TabIndex = 4;
            this.lblPrecioAPagar.Text = "Precio a pagar:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(217, 252);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "precio";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNICliente.Location = new System.Drawing.Point(82, 287);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(130, 16);
            this.lblDNICliente.TabIndex = 6;
            this.lblDNICliente.Text = "Ingresar DNI Cliente:";
            // 
            // txbDNICliente
            // 
            this.txbDNICliente.Location = new System.Drawing.Point(218, 287);
            this.txbDNICliente.Name = "txbDNICliente";
            this.txbDNICliente.Size = new System.Drawing.Size(186, 20);
            this.txbDNICliente.TabIndex = 7;
            // 
            // lblNombreCompletoCliente
            // 
            this.lblNombreCompletoCliente.AutoSize = true;
            this.lblNombreCompletoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompletoCliente.Location = new System.Drawing.Point(49, 356);
            this.lblNombreCompletoCliente.Name = "lblNombreCompletoCliente";
            this.lblNombreCompletoCliente.Size = new System.Drawing.Size(163, 16);
            this.lblNombreCompletoCliente.TabIndex = 8;
            this.lblNombreCompletoCliente.Text = "Nombre completo Cliente:";
            this.lblNombreCompletoCliente.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "DNI Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbEdadCliente);
            this.groupBox1.Controls.Add(this.txbTelefonoCliente);
            this.groupBox1.Controls.Add(this.txbDNI_Cliente);
            this.groupBox1.Controls.Add(this.txbNombreCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTelefonoCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente:";
            // 
            // txbEdadCliente
            // 
            this.txbEdadCliente.Location = new System.Drawing.Point(185, 108);
            this.txbEdadCliente.Name = "txbEdadCliente";
            this.txbEdadCliente.Size = new System.Drawing.Size(186, 21);
            this.txbEdadCliente.TabIndex = 15;
            // 
            // txbTelefonoCliente
            // 
            this.txbTelefonoCliente.Location = new System.Drawing.Point(185, 80);
            this.txbTelefonoCliente.Name = "txbTelefonoCliente";
            this.txbTelefonoCliente.Size = new System.Drawing.Size(186, 21);
            this.txbTelefonoCliente.TabIndex = 14;
            // 
            // txbDNI_Cliente
            // 
            this.txbDNI_Cliente.Location = new System.Drawing.Point(185, 53);
            this.txbDNI_Cliente.Name = "txbDNI_Cliente";
            this.txbDNI_Cliente.Size = new System.Drawing.Size(186, 21);
            this.txbDNI_Cliente.TabIndex = 13;
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.Location = new System.Drawing.Point(185, 24);
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.Size = new System.Drawing.Size(186, 21);
            this.txbNombreCliente.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edad Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(70, 82);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(109, 16);
            this.lblTelefonoCliente.TabIndex = 10;
            this.lblTelefonoCliente.Text = "Teléfono Cliente:";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(105, 491);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(106, 16);
            this.lblFechaRegistro.TabIndex = 11;
            this.lblFechaRegistro.Text = "Fecha  Registro:";
            // 
            // lblFechaRegistroMostrar
            // 
            this.lblFechaRegistroMostrar.AutoSize = true;
            this.lblFechaRegistroMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistroMostrar.Location = new System.Drawing.Point(220, 491);
            this.lblFechaRegistroMostrar.Name = "lblFechaRegistroMostrar";
            this.lblFechaRegistroMostrar.Size = new System.Drawing.Size(41, 16);
            this.lblFechaRegistroMostrar.TabIndex = 12;
            this.lblFechaRegistroMostrar.Text = "fecha";
            // 
            // btnEditarFecha
            // 
            this.btnEditarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFecha.Location = new System.Drawing.Point(289, 485);
            this.btnEditarFecha.Name = "btnEditarFecha";
            this.btnEditarFecha.Size = new System.Drawing.Size(115, 28);
            this.btnEditarFecha.TabIndex = 13;
            this.btnEditarFecha.Text = "Editar Fecha";
            this.btnEditarFecha.UseVisualStyleBackColor = true;
            // 
            // btnRegistroServicio
            // 
            this.btnRegistroServicio.Location = new System.Drawing.Point(623, 35);
            this.btnRegistroServicio.Name = "btnRegistroServicio";
            this.btnRegistroServicio.Size = new System.Drawing.Size(125, 29);
            this.btnRegistroServicio.TabIndex = 14;
            this.btnRegistroServicio.Text = "REGISTRAR VENTA";
            this.btnRegistroServicio.UseVisualStyleBackColor = true;
            // 
            // btnAnularVenta
            // 
            this.btnAnularVenta.Location = new System.Drawing.Point(623, 98);
            this.btnAnularVenta.Name = "btnAnularVenta";
            this.btnAnularVenta.Size = new System.Drawing.Size(125, 27);
            this.btnAnularVenta.TabIndex = 15;
            this.btnAnularVenta.Text = "ANULAR VENTA";
            this.btnAnularVenta.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(623, 159);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 26);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(428, 285);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(114, 23);
            this.btnBuscarCliente.TabIndex = 17;
            this.btnBuscarCliente.Text = "BUSCAR CLIENTE";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // CORE_VENTA_SERVICIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnularVenta);
            this.Controls.Add(this.btnRegistroServicio);
            this.Controls.Add(this.btnEditarFecha);
            this.Controls.Add(this.lblFechaRegistroMostrar);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.lblNombreCompletoCliente);
            this.Controls.Add(this.txbDNICliente);
            this.Controls.Add(this.lblDNICliente);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPrecioAPagar);
            this.Controls.Add(this.cbxTipoPlan);
            this.Controls.Add(this.lblTipoPlan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblVentaServicios);
            this.Controls.Add(this.groupBox1);
            this.Name = "CORE_VENTA_SERVICIOS";
            this.Text = "CORE_VENTA_SERVICIOS";
            this.Load += new System.EventHandler(this.CORE_VENTA_SERVICIOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentaServicios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.ComboBox cbxTipoPlan;
        private System.Windows.Forms.Label lblPrecioAPagar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.TextBox txbDNICliente;
        private System.Windows.Forms.Label lblNombreCompletoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEdadCliente;
        private System.Windows.Forms.TextBox txbTelefonoCliente;
        private System.Windows.Forms.TextBox txbDNI_Cliente;
        private System.Windows.Forms.TextBox txbNombreCliente;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistroMostrar;
        private System.Windows.Forms.Button btnEditarFecha;
        private System.Windows.Forms.Button btnRegistroServicio;
        private System.Windows.Forms.Button btnAnularVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}