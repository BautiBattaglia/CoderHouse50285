namespace _ALaCarta
{
    partial class frmALaCarta
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
            lstCartaRestaurant = new ListBox();
            SuspendLayout();
            // 
            // lstCartaRestaurant
            // 
            lstCartaRestaurant.FormattingEnabled = true;
            lstCartaRestaurant.ItemHeight = 15;
            lstCartaRestaurant.Location = new Point(302, 164);
            lstCartaRestaurant.Name = "lstCartaRestaurant";
            lstCartaRestaurant.Size = new Size(656, 199);
            lstCartaRestaurant.TabIndex = 0;
            // 
            // frmALaCarta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1341, 579);
            Controls.Add(lstCartaRestaurant);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmALaCarta";
            ShowIcon = false;
            Text = "#ALaCarta";
            TopMost = true;
            Load += frmALaCarta_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstCartaRestaurant;
    }
}
