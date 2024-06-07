namespace Turky_sGym_Programa
{
    partial class formStockProducto
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
            this.dgvStockProducto = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grbDatosProducto = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbIDpro = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProducto)).BeginInit();
            this.grbDatosProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockProducto
            // 
            this.dgvStockProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockProducto.Location = new System.Drawing.Point(12, 12);
            this.dgvStockProducto.Name = "dgvStockProducto";
            this.dgvStockProducto.Size = new System.Drawing.Size(535, 239);
            this.dgvStockProducto.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(573, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 50);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(573, 388);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 50);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(573, 201);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 50);
            this.btnInhabilitar.TabIndex = 3;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(573, 102);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 50);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // grbDatosProducto
            // 
            this.grbDatosProducto.Controls.Add(this.btnModificar);
            this.grbDatosProducto.Controls.Add(this.btnCancelar);
            this.grbDatosProducto.Controls.Add(this.btnInsertar);
            this.grbDatosProducto.Controls.Add(this.txtPrecio);
            this.grbDatosProducto.Controls.Add(this.txtCantidad);
            this.grbDatosProducto.Controls.Add(this.txtTipo);
            this.grbDatosProducto.Controls.Add(this.txtMarca);
            this.grbDatosProducto.Controls.Add(this.cmbCategoria);
            this.grbDatosProducto.Controls.Add(this.lbPrecio);
            this.grbDatosProducto.Controls.Add(this.lbCantidad);
            this.grbDatosProducto.Controls.Add(this.lbTipo);
            this.grbDatosProducto.Controls.Add(this.lbMarca);
            this.grbDatosProducto.Controls.Add(this.lbCategoria);
            this.grbDatosProducto.Controls.Add(this.lbID);
            this.grbDatosProducto.Controls.Add(this.lbIDpro);
            this.grbDatosProducto.Location = new System.Drawing.Point(12, 268);
            this.grbDatosProducto.Name = "grbDatosProducto";
            this.grbDatosProducto.Size = new System.Drawing.Size(535, 170);
            this.grbDatosProducto.TabIndex = 5;
            this.grbDatosProducto.TabStop = false;
            this.grbDatosProducto.Text = "Datos del Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(55, 148);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(136, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(64, 126);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(127, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(43, 102);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(148, 20);
            this.txtTipo.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(52, 76);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(139, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Bebida",
            "Vestimenta",
            "Sumplemento",
            "Accesorio"});
            this.cmbCategoria.Location = new System.Drawing.Point(70, 48);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(9, 151);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(40, 13);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(6, 129);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(52, 13);
            this.lbCantidad.TabIndex = 5;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(6, 105);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 4;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(6, 79);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(40, 13);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(6, 51);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(58, 13);
            this.lbCategoria.TabIndex = 2;
            this.lbCategoria.Text = "Categoria: ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(80, 25);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(19, 13);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "00";
            // 
            // lbIDpro
            // 
            this.lbIDpro.AutoSize = true;
            this.lbIDpro.Location = new System.Drawing.Point(6, 25);
            this.lbIDpro.Name = "lbIDpro";
            this.lbIDpro.Size = new System.Drawing.Size(67, 13);
            this.lbIDpro.TabIndex = 0;
            this.lbIDpro.Text = "ID Producto:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(454, 19);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 35);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(454, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(454, 68);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // formStockProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.grbDatosProducto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvStockProducto);
            this.Name = "formStockProducto";
            this.Text = "formStockProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProducto)).EndInit();
            this.grbDatosProducto.ResumeLayout(false);
            this.grbDatosProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockProducto;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grbDatosProducto;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbIDpro;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
    }
}