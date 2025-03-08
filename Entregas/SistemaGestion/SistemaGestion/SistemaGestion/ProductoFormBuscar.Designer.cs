namespace SistemaGestion
{
    partial class ProductoFormBuscar
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
            lblDatosEncontradosProducto = new Label();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtProductoID = new TextBox();
            btnBuscarProducto = new Button();
            txtBuscarProductoID = new Label();
            lblTituloBuscarProducto = new Label();
            txtStock = new TextBox();
            SuspendLayout();
            // 
            // lblDatosEncontradosProducto
            // 
            lblDatosEncontradosProducto.AutoSize = true;
            lblDatosEncontradosProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosEncontradosProducto.Location = new Point(22, 154);
            lblDatosEncontradosProducto.Name = "lblDatosEncontradosProducto";
            lblDatosEncontradosProducto.Size = new Size(231, 35);
            lblDatosEncontradosProducto.TabIndex = 39;
            lblDatosEncontradosProducto.Text = "Datos encontrados:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(51, 264);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(70, 30);
            lblStock.TabIndex = 35;
            lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(126, 234);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 34;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(42, 229);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(78, 30);
            lblPrecio.TabIndex = 33;
            lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(21, 198);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 30);
            lblNombre.TabIndex = 32;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 201);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 31;
            // 
            // txtProductoID
            // 
            txtProductoID.Location = new Point(126, 54);
            txtProductoID.Name = "txtProductoID";
            txtProductoID.Size = new Size(125, 27);
            txtProductoID.TabIndex = 29;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = SystemColors.Control;
            btnBuscarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProducto.Location = new Point(141, 98);
            btnBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(99, 40);
            btnBuscarProducto.TabIndex = 28;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtBuscarProductoID
            // 
            txtBuscarProductoID.AutoSize = true;
            txtBuscarProductoID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarProductoID.Location = new Point(81, 49);
            txtBuscarProductoID.Name = "txtBuscarProductoID";
            txtBuscarProductoID.Size = new Size(39, 30);
            txtBuscarProductoID.TabIndex = 27;
            txtBuscarProductoID.Text = "ID:";
            // 
            // lblTituloBuscarProducto
            // 
            lblTituloBuscarProducto.AutoSize = true;
            lblTituloBuscarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloBuscarProducto.Location = new Point(12, 9);
            lblTituloBuscarProducto.Name = "lblTituloBuscarProducto";
            lblTituloBuscarProducto.Size = new Size(279, 35);
            lblTituloBuscarProducto.TabIndex = 40;
            lblTituloBuscarProducto.Text = "Ingrese ID de producto:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(126, 269);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 41;
            // 
            // ProductoFormBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(319, 315);
            Controls.Add(txtStock);
            Controls.Add(lblTituloBuscarProducto);
            Controls.Add(lblDatosEncontradosProducto);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(txtProductoID);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtBuscarProductoID);
            Name = "ProductoFormBuscar";
            Text = "ProductoFormBuscar";
            Load += ProductoFormBuscar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosEncontradosProducto;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblStock;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtProductoID;
        private Button btnBuscarProducto;
        private Label txtBuscarProductoID;
        private Label lblTituloBuscarProducto;
        private TextBox txtStock;
    }
}