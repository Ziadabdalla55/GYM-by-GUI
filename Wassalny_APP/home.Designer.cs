namespace wsallny
{
    partial class home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container = new Guna.UI.WinForms.GunaGradient2Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.Cursor = System.Windows.Forms.Cursors.No;
            this.container.GradientColor1 = System.Drawing.SystemColors.Window;
            this.container.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Radius = 15;
            this.container.Size = new System.Drawing.Size(1067, 657);
            this.container.TabIndex = 1;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.container);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1067, 657);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel container;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
