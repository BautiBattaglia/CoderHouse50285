namespace SistemaGestion
{
    partial class ProductoFormEliminar
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
            label1 = new Label();
            txtProductoID = new TextBox();
            btnEliminarProducto = new Button();
            txtBuscarUsuarioID = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 35);
            label1.TabIndex = 25;
            label1.Text = "Ingrese ID de producto:";
            // 
            // txtProductoID
            // 
            txtProductoID.Location = new Point(126, 54);
            txtProductoID.Name = "txtProductoID";
            txtProductoID.Size = new Size(125, 27);
            txtProductoID.TabIndex = 24;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = SystemColors.Control;
            btnEliminarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarProducto.Location = new Point(126, 98);
            btnEliminarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(114, 40);
            btnEliminarProducto.TabIndex = 23;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // txtBuscarUsuarioID
            // 
            txtBuscarUsuarioID.AutoSize = true;
            txtBuscarUsuarioID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarUsuarioID.Location = new Point(81, 49);
            txtBuscarUsuarioID.Name = "txtBuscarUsuarioID";
            txtBuscarUsuarioID.Size = new Size(39, 30);
            txtBuscarUsuarioID.TabIndex = 22;
            txtBuscarUsuarioID.Text = "ID:";
            // 
            // ProductoFormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(291, 154);
            Controls.Add(label1);
            Controls.Add(txtProductoID);
            Controls.Add(btnEliminarProducto);
            Controls.Add(txtBuscarUsuarioID);
            Name = "ProductoFormEliminar";
            Text = "ProductoFormEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductoID;
        private Button btnEliminarProducto;
        private Label txtBuscarUsuarioID;
    }
}