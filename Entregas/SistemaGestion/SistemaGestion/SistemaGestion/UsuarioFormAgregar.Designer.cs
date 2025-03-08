namespace SistemaGestion
{
    partial class UsuarioFormAgregar
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
            btnAgregarUsuario = new Button();
            lblCompletarDatosUsuario = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = SystemColors.Control;
            btnAgregarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarUsuario.Location = new Point(68, 192);
            btnAgregarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(114, 42);
            btnAgregarUsuario.TabIndex = 0;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // lblCompletarDatosUsuario
            // 
            lblCompletarDatosUsuario.AutoSize = true;
            lblCompletarDatosUsuario.Location = new Point(346, 24);
            lblCompletarDatosUsuario.Name = "lblCompletarDatosUsuario";
            lblCompletarDatosUsuario.Size = new Size(0, 20);
            lblCompletarDatosUsuario.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(21, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 30);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(22, 87);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(98, 30);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(126, 92);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(51, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 30);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(12, 153);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 30);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 12;
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
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(253, 37);
            label2.TabIndex = 18;
            label2.Text = "Complete los datos:";
            // 
            // UsuarioFormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(291, 271);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblCompletarDatosUsuario);
            Controls.Add(btnAgregarUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsuarioFormAgregar";
            Text = "UsuarioForm";
            Load += UsuarioFormAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarUsuario;
        private Label lblCompletarDatosUsuario;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
    }
}