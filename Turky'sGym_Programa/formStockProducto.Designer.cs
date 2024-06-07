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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProducto)).BeginInit();
            this.grbDatosProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockProducto
            // 
            this.dgvStockProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockProducto.Location = new System.Drawing.Point(16, 15);
            this.dgvStockProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStockProducto.Name = "dgvStockProducto";
            this.dgvStockProducto.RowHeadersWidth = 51;
            this.dgvStockProducto.Size = new System.Drawing.Size(713, 294);
            this.dgvStockProducto.TabIndex = 0;
            this.dgvStockProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockProducto_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(764, 15);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(133, 62);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(764, 478);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 62);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(764, 247);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(133, 62);
            this.btnInhabilitar.TabIndex = 3;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(764, 126);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 62);
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
            this.grbDatosProducto.Location = new System.Drawing.Point(16, 330);
            this.grbDatosProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosProducto.Name = "grbDatosProducto";
            this.grbDatosProducto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosProducto.Size = new System.Drawing.Size(713, 209);
            this.grbDatosProducto.TabIndex = 5;
            this.grbDatosProducto.TabStop = false;
            this.grbDatosProducto.Text = "Datos del Producto";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(605, 84);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 43);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(605, 148);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 43);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(605, 23);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 43);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(73, 182);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 22);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(85, 155);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 22);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(57, 126);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(196, 22);
            this.txtTipo.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(69, 94);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(184, 22);
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
            this.cmbCategoria.Location = new System.Drawing.Point(93, 59);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(160, 24);
            this.cmbCategoria.TabIndex = 7;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(12, 186);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(49, 16);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(8, 159);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(64, 16);
            this.lbCantidad.TabIndex = 5;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(8, 129);
            this.lbTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(38, 16);
            this.lbTipo.TabIndex = 4;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(8, 97);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(48, 16);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(8, 63);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(72, 16);
            this.lbCategoria.TabIndex = 2;
            this.lbCategoria.Text = "Categoria: ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(107, 31);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 16);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "00";
            // 
            // lbIDpro
            // 
            this.lbIDpro.AutoSize = true;
            this.lbIDpro.Location = new System.Drawing.Point(8, 31);
            this.lbIDpro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDpro.Name = "lbIDpro";
            this.lbIDpro.Size = new System.Drawing.Size(80, 16);
            this.lbIDpro.TabIndex = 0;
            this.lbIDpro.Text = "ID Producto:";
            // 
            // formStockProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 554);
            this.Controls.Add(this.grbDatosProducto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvStockProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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