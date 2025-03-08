namespace SistemaGestion
{
    partial class ProductoFormModificar
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
            lblTituloModificarDatosProducto = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTituloModificarProducto = new Label();
            txtProductoID = new TextBox();
            btnModificarProducto = new Button();
            txtBuscarProductoID = new Label();
            btnBuscarProducto = new Button();
            SuspendLayout();
            // 
            // lblTituloModificarDatosProducto
            // 
            lblTituloModificarDatosProducto.AutoSize = true;
            lblTituloModificarDatosProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloModificarDatosProducto.Location = new Point(12, 84);
            lblTituloModificarDatosProducto.Name = "lblTituloModificarDatosProducto";
            lblTituloModificarDatosProducto.Size = new Size(268, 35);
            lblTituloModificarDatosProducto.TabIndex = 52;
            lblTituloModificarDatosProducto.Text = "Modificación de datos:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(126, 192);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 50;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(51, 189);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(70, 30);
            lblStock.TabIndex = 48;
            lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(126, 159);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 47;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(42, 154);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(78, 30);
            lblPrecio.TabIndex = 46;
            lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(21, 123);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 30);
            lblNombre.TabIndex = 45;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 44;
            // 
            // lblTituloModificarProducto
            // 
            lblTituloModificarProducto.AutoSize = true;
            lblTituloModificarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloModificarProducto.Location = new Point(12, 9);
            lblTituloModificarProducto.Name = "lblTituloModificarProducto";
            lblTituloModificarProducto.Size = new Size(279, 35);
            lblTituloModificarProducto.TabIndex = 43;
            lblTituloModificarProducto.Text = "Ingrese ID de producto:";
            // 
            // txtProductoID
            // 
            txtProductoID.Location = new Point(126, 54);
            txtProductoID.Name = "txtProductoID";
            txtProductoID.Size = new Size(125, 27);
            txtProductoID.TabIndex = 42;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = SystemColors.Control;
            btnModificarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarProducto.Location = new Point(157, 244);
            btnModificarProducto.Margin = new Padding(3, 4, 3, 4);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(134, 40);
            btnModificarProducto.TabIndex = 41;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // txtBuscarProductoID
            // 
            txtBuscarProductoID.AutoSize = true;
            txtBuscarProductoID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarProductoID.Location = new Point(81, 49);
            txtBuscarProductoID.Name = "txtBuscarProductoID";
            txtBuscarProductoID.Size = new Size(39, 30);
            txtBuscarProductoID.TabIndex = 40;
            txtBuscarProductoID.Text = "ID:";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = SystemColors.Control;
            btnBuscarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProducto.Location = new Point(12, 244);
            btnBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(134, 40);
            btnBuscarProducto.TabIndex = 53;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // ProductoFormModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(304, 297);
            Controls.Add(btnBuscarProducto);
            Controls.Add(lblTituloModificarDatosProducto);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTituloModificarProducto);
            Controls.Add(txtProductoID);
            Controls.Add(btnModificarProducto);
            Controls.Add(txtBuscarProductoID);
            Name = "ProductoFormModificar";
            Text = "ProductoFormModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloModificarDatosProducto;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTituloModificarProducto;
        private TextBox txtProductoID;
        private Button btnModificarProducto;
        private Label txtBuscarProductoID;
        private Button btnBuscarProducto;
    }
}