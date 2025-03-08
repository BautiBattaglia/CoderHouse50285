namespace SistemaGestion
{
    partial class UsuarioFormEliminar
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
            txtUsuarioID = new TextBox();
            btnEliminarUsuario = new Button();
            txtBuscarUsuarioID = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 35);
            label1.TabIndex = 21;
            label1.Text = "Ingrese ID de usuario:";
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Location = new Point(126, 54);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(125, 27);
            txtUsuarioID.TabIndex = 20;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = SystemColors.Control;
            btnEliminarUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarUsuario.Location = new Point(126, 98);
            btnEliminarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(114, 40);
            btnEliminarUsuario.TabIndex = 19;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // txtBuscarUsuarioID
            // 
            txtBuscarUsuarioID.AutoSize = true;
            txtBuscarUsuarioID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarUsuarioID.Location = new Point(81, 49);
            txtBuscarUsuarioID.Name = "txtBuscarUsuarioID";
            txtBuscarUsuarioID.Size = new Size(39, 30);
            txtBuscarUsuarioID.TabIndex = 18;
            txtBuscarUsuarioID.Text = "ID:";
            // 
            // UsuarioFormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(292, 160);
            Controls.Add(label1);
            Controls.Add(txtUsuarioID);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(txtBuscarUsuarioID);
            Name = "UsuarioFormEliminar";
            Text = "UsuarioFormEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuarioID;
        private Button btnEliminarUsuario;
        private Label txtBuscarUsuarioID;
    }
}