namespace Clase7
{
    partial class DiccionariosListas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstRazasDePerros = new ListBox();
            lstCiudadesPais = new ListBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lstRazasDePerros
            // 
            lstRazasDePerros.FormattingEnabled = true;
            lstRazasDePerros.ItemHeight = 15;
            lstRazasDePerros.Location = new Point(150, 225);
            lstRazasDePerros.Name = "lstRazasDePerros";
            lstRazasDePerros.Size = new Size(167, 169);
            lstRazasDePerros.TabIndex = 0;
            lstRazasDePerros.Tag = "Razas de Perros";
            // 
            // lstCiudadesPais
            // 
            lstCiudadesPais.FormattingEnabled = true;
            lstCiudadesPais.ItemHeight = 15;
            lstCiudadesPais.Location = new Point(344, 225);
            lstCiudadesPais.Name = "lstCiudadesPais";
            lstCiudadesPais.Size = new Size(167, 169);
            lstCiudadesPais.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(344, 87);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(344, 116);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(344, 145);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(344, 174);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Buscar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(lstCiudadesPais);
            Controls.Add(lstRazasDePerros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstRazasDePerros;
        private ListBox lstCiudadesPais;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBuscar;
        private Button btnLimpiar;
    }
}
