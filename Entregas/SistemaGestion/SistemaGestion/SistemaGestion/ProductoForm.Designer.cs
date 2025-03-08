namespace SistemaGestion
{
    partial class ProductoForm
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
            btnAgregarProducto = new Button();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnBuscarProducto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 22;
            label1.Text = "Menú Productos";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = SystemColors.Control;
            btnAgregarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProducto.Location = new Point(12, 50);
            btnAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(114, 42);
            btnAgregarProducto.TabIndex = 21;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = SystemColors.Control;
            btnEliminarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarProducto.Location = new Point(12, 195);
            btnEliminarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(114, 41);
            btnEliminarProducto.TabIndex = 20;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = SystemColors.Control;
            btnModificarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarProducto.Location = new Point(12, 148);
            btnModificarProducto.Margin = new Padding(3, 4, 3, 4);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(133, 39);
            btnModificarProducto.TabIndex = 19;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = SystemColors.Control;
            btnBuscarProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProducto.Location = new Point(12, 100);
            btnBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(99, 40);
            btnBuscarProducto.TabIndex = 18;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(275, 265);
            Controls.Add(label1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnBuscarProducto);
            Name = "ProductoForm";
            Text = "ProductoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregarProducto;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnBuscarProducto;
    }
}