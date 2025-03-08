namespace SistemaGestionApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnUsuarios = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnProductosVendidos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = SystemColors.Control;
            btnUsuarios.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(12, 64);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(120, 39);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.Control;
            btnProductos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.Location = new Point(12, 109);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(138, 40);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.Control;
            btnVentas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.Location = new Point(12, 155);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(97, 41);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductosVendidos
            // 
            btnProductosVendidos.BackColor = SystemColors.Control;
            btnProductosVendidos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductosVendidos.Location = new Point(12, 202);
            btnProductosVendidos.Name = "btnProductosVendidos";
            btnProductosVendidos.Size = new Size(247, 38);
            btnProductosVendidos.TabIndex = 3;
            btnProductosVendidos.Text = "Productos Vendidos";
            btnProductosVendidos.UseVisualStyleBackColor = false;
            btnProductosVendidos.Click += btnProductosVendidos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 4;
            label1.Text = "Menú administrador";
            // 
            // MainForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(292, 267);
            Controls.Add(label1);
            Controls.Add(btnProductosVendidos);
            Controls.Add(btnVentas);
            Controls.Add(btnProductos);
            Controls.Add(btnUsuarios);
            Name = "MainForm";
            Text = "Sistema de Gestión";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductosVendidos;
        private Label label1;
    }
}
