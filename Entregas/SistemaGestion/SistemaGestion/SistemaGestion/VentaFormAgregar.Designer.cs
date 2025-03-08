namespace SistemaGestion
{
    partial class VentaFormAgregar
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
            lblIdCliente = new Label();
            label2 = new Label();
            lblMontoTotal = new Label();
            txtIdCliente = new TextBox();
            txtMontoTotal = new TextBox();
            btnAgregarVenta = new Button();
            SuspendLayout();
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdCliente.Location = new Point(12, 65);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(88, 25);
            lblIdCliente.TabIndex = 7;
            lblIdCliente.Text = "ID Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(205, 30);
            label2.TabIndex = 19;
            label2.Text = "Complete los datos:";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoTotal.Location = new Point(12, 90);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(112, 25);
            lblMontoTotal.TabIndex = 20;
            lblMontoTotal.Text = "Monto Total:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(130, 65);
            txtIdCliente.Margin = new Padding(3, 2, 3, 2);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(110, 23);
            txtIdCliente.TabIndex = 21;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(130, 92);
            txtMontoTotal.Margin = new Padding(3, 2, 3, 2);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(110, 23);
            txtMontoTotal.TabIndex = 22;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.BackColor = SystemColors.Control;
            btnAgregarVenta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarVenta.Location = new Point(140, 127);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(100, 32);
            btnAgregarVenta.TabIndex = 23;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = false;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // VentaFormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(256, 171);
            Controls.Add(btnAgregarVenta);
            Controls.Add(txtMontoTotal);
            Controls.Add(txtIdCliente);
            Controls.Add(lblMontoTotal);
            Controls.Add(label2);
            Controls.Add(lblIdCliente);
            Name = "VentaFormAgregar";
            Text = "VentaFormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdCliente;
        private Label label2;
        private Label lblMontoTotal;
        private TextBox txtIdCliente;
        private TextBox txtMontoTotal;
        private Button btnAgregarVenta;
    }
}