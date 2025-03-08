namespace SistemaGestion
{
    partial class UsuarioForm
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
            btnBuscarUsuario = new Button();
            btnModificarUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnAgregarUsuario = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = SystemColors.Control;
            btnBuscarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarUsuario.Location = new Point(10, 75);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(87, 30);
            btnBuscarUsuario.TabIndex = 4;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.BackColor = SystemColors.Control;
            btnModificarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarUsuario.Location = new Point(10, 111);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(116, 29);
            btnModificarUsuario.TabIndex = 5;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.UseVisualStyleBackColor = false;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = SystemColors.Control;
            btnEliminarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarUsuario.Location = new Point(10, 146);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(100, 31);
            btnEliminarUsuario.TabIndex = 6;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = SystemColors.Control;
            btnAgregarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarUsuario.Location = new Point(10, 38);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(100, 31);
            btnAgregarUsuario.TabIndex = 7;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.TextAlign = ContentAlignment.TopCenter;
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 17;
            label1.Text = "Menú Usuarios";
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(224, 193);
            Controls.Add(label1);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnBuscarUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuarioForm";
            Text = "UsuarioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarUsuario;
        private Button btnModificarUsuario;
        private Button btnEliminarUsuario;
        private Button btnAgregarUsuario;
        private Label label1;
    }
}