namespace SistemaGestion
{
    partial class UsuarioFormBuscar
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
            txtBuscarUsuarioID = new Label();
            btnBuscarUsuario = new Button();
            txtUsuarioID = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBuscarUsuarioID
            // 
            txtBuscarUsuarioID.AutoSize = true;
            txtBuscarUsuarioID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarUsuarioID.Location = new Point(100, 49);
            txtBuscarUsuarioID.Name = "txtBuscarUsuarioID";
            txtBuscarUsuarioID.Size = new Size(39, 30);
            txtBuscarUsuarioID.TabIndex = 14;
            txtBuscarUsuarioID.Text = "ID:";
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = SystemColors.Control;
            btnBuscarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarUsuario.Location = new Point(160, 98);
            btnBuscarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(99, 40);
            btnBuscarUsuario.TabIndex = 15;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Location = new Point(145, 54);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(125, 27);
            txtUsuarioID.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 35);
            label1.TabIndex = 17;
            label1.Text = "Ingrese ID de usuario:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(145, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 24;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(31, 295);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 30);
            lblPassword.TabIndex = 23;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(70, 264);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 30);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(145, 234);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 21;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(41, 229);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(98, 30);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(40, 198);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 30);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 201);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 154);
            label2.Name = "label2";
            label2.Size = new Size(231, 35);
            label2.TabIndex = 26;
            label2.Text = "Datos encontrados:";
            // 
            // UsuarioFormBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(318, 348);
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
            Controls.Add(btnBuscarUsuario);
            Controls.Add(txtBuscarUsuarioID);
            Name = "UsuarioFormBuscar";
            Text = "UsuarioFormBuscar";
            Load += UsuarioFormBuscar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtBuscarUsuarioID;
        private Button btnBuscarUsuario;
        private TextBox txtUsuarioID;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label2;
    }
}