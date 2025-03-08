namespace SistemaGestion
{
    partial class VentaForm
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
            btnConsultarVenta = new Button();
            btnAgregarVenta = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnConsultarVenta
            // 
            btnConsultarVenta.BackColor = SystemColors.Control;
            btnConsultarVenta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarVenta.Location = new Point(12, 73);
            btnConsultarVenta.Name = "btnConsultarVenta";
            btnConsultarVenta.Size = new Size(119, 32);
            btnConsultarVenta.TabIndex = 9;
            btnConsultarVenta.Text = "Consultar";
            btnConsultarVenta.UseVisualStyleBackColor = false;
            btnConsultarVenta.Click += btnConsultarVenta_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.BackColor = SystemColors.Control;
            btnAgregarVenta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarVenta.Location = new Point(12, 35);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(119, 32);
            btnAgregarVenta.TabIndex = 10;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = false;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 2);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 18;
            label2.Text = "Menú Ventas";
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(204, 132);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregarVenta);
            Controls.Add(btnConsultarVenta);
            Name = "VentaForm";
            Text = "VentaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultarVenta;
        private Button btnAgregarVenta;
        private Label label1;
        private Label label2;
    }
}