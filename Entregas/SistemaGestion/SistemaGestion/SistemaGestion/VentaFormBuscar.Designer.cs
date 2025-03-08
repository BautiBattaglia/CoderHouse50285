namespace SistemaGestion
{
    partial class VentaFormBuscar
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
            txtBuscarUsuarioID = new Label();
            txtUsuarioID = new TextBox();
            btnBuscarUsuario = new Button();
            lblIdCliente = new Label();
            lblMontoTotal = new Label();
            txtNombre = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 28);
            label1.TabIndex = 18;
            label1.Text = "Ingrese ID de usuario:";
            // 
            // txtBuscarUsuarioID
            // 
            txtBuscarUsuarioID.AutoSize = true;
            txtBuscarUsuarioID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarUsuarioID.Location = new Point(44, 48);
            txtBuscarUsuarioID.Name = "txtBuscarUsuarioID";
            txtBuscarUsuarioID.Size = new Size(34, 25);
            txtBuscarUsuarioID.TabIndex = 19;
            txtBuscarUsuarioID.Text = "ID:";
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Location = new Point(97, 51);
            txtUsuarioID.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(110, 23);
            txtUsuarioID.TabIndex = 20;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = SystemColors.Control;
            btnBuscarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarUsuario.Location = new Point(120, 79);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(87, 30);
            btnBuscarUsuario.TabIndex = 21;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdCliente.Location = new Point(12, 179);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(92, 25);
            lblIdCliente.TabIndex = 28;
            lblIdCliente.Text = "ID Cliente:";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoTotal.Location = new Point(12, 213);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(112, 25);
            lblMontoTotal.TabIndex = 29;
            lblMontoTotal.Text = "Monto Total:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 182);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 216);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 130);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 32;
            label2.Text = "Datos encontrados:";
            // 
            // VentaFormBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(250, 259);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(txtNombre);
            Controls.Add(lblMontoTotal);
            Controls.Add(lblIdCliente);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(txtUsuarioID);
            Controls.Add(txtBuscarUsuarioID);
            Controls.Add(label1);
            Name = "VentaFormBuscar";
            Text = "VentaFormBuscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtBuscarUsuarioID;
        private TextBox txtUsuarioID;
        private Button btnBuscarUsuario;
        private Label lblIdCliente;
        private Label lblMontoTotal;
        private TextBox txtNombre;
        private TextBox textBox1;
        private Label label2;
    }
}