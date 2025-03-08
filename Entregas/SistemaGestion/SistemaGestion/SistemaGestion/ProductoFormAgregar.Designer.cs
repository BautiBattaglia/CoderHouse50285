namespace SistemaGestion
{
    partial class ProductoFormAgregar
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
            lblPassword = new Label();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnAgregarProducto = new Button();
            label2 = new Label();
            txtStock = new TextBox();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(3, 149);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 30);
            lblPassword.TabIndex = 19;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(42, 118);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(70, 30);
            lblStock.TabIndex = 18;
            lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(117, 88);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 17;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(33, 82);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(78, 30);
            lblPrecio.TabIndex = 16;
            lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 30);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 14;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = SystemColors.Control;
            btnAgregarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProducto.Location = new Point(78, 155);
            btnAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(114, 42);
            btnAgregarProducto.TabIndex = 13;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(253, 37);
            label2.TabIndex = 22;
            label2.Text = "Complete los datos:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(117, 121);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 23;
            // 
            // ProductoFormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(292, 229);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(lblPassword);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregarProducto);
            Name = "ProductoFormAgregar";
            Text = "ProductoFormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblStock;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnAgregarProducto;
        private Label label2;
        private TextBox txtStock;
    }
}