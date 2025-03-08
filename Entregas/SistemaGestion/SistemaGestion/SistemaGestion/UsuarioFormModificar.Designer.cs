namespace SistemaGestion
{
    partial class UsuarioFormModificar
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
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtUsuarioID = new TextBox();
            btnModificarUsuario = new Button();
            txtBuscarUsuarioID = new Label();
            label2 = new Label();
            btnBuscarUsuario = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(131, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 37;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(17, 224);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 30);
            lblPassword.TabIndex = 36;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(56, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 30);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(131, 163);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 34;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(27, 158);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(98, 30);
            lblApellido.TabIndex = 33;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(26, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 30);
            lblNombre.TabIndex = 32;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(258, 35);
            label1.TabIndex = 30;
            label1.Text = "Ingrese ID de usuario:";
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Location = new Point(131, 58);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(125, 27);
            txtUsuarioID.TabIndex = 29;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.BackColor = SystemColors.Control;
            btnModificarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarUsuario.Location = new Point(156, 279);
            btnModificarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(134, 40);
            btnModificarUsuario.TabIndex = 28;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.UseVisualStyleBackColor = false;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // txtBuscarUsuarioID
            // 
            txtBuscarUsuarioID.AutoSize = true;
            txtBuscarUsuarioID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarUsuarioID.Location = new Point(86, 53);
            txtBuscarUsuarioID.Name = "txtBuscarUsuarioID";
            txtBuscarUsuarioID.Size = new Size(39, 30);
            txtBuscarUsuarioID.TabIndex = 27;
            txtBuscarUsuarioID.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 88);
            label2.Name = "label2";
            label2.Size = new Size(268, 35);
            label2.TabIndex = 39;
            label2.Text = "Modificación de datos:";
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = SystemColors.Control;
            btnBuscarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarUsuario.Location = new Point(12, 279);
            btnBuscarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(134, 40);
            btnBuscarUsuario.TabIndex = 40;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // UsuarioFormModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(302, 338);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtUsuarioID);
            Controls.Add(btnModificarUsuario);
            Controls.Add(txtBuscarUsuarioID);
            Name = "UsuarioFormModificar";
            Text = "UsuarioFormModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtUsuarioID;
        private Button btnModificarUsuario;
        private Label txtBuscarUsuarioID;
        private Label label2;
        private Button btnBuscarUsuario;
    }
}