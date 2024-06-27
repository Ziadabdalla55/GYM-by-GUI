namespace wsallny
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.container = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.nav_bar = new Guna.UI.WinForms.GunaGradient2Panel();
            this.logout_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.info_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.anas_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.hamdy_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.khaled_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.home_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.trans_img = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGradient2Panel2.SuspendLayout();
            this.nav_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trans_img)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.Cursor = System.Windows.Forms.Cursors.No;
            this.container.GradientColor1 = System.Drawing.Color.White;
            this.container.GradientColor2 = System.Drawing.Color.White;
            this.container.Location = new System.Drawing.Point(115, 0);
            this.container.Name = "container";
            this.container.Radius = 15;
            this.container.Size = new System.Drawing.Size(1067, 657);
            this.container.TabIndex = 0;
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.nav_bar);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.White;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(1, 0);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(115, 657);
            this.gunaGradient2Panel2.TabIndex = 0;
            this.gunaGradient2Panel2.Click += new System.EventHandler(this.gunaGradient2Panel2_Click);
            this.gunaGradient2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel2_Paint);
            // 
            // nav_bar
            // 
            this.nav_bar.BackColor = System.Drawing.Color.Transparent;
            this.nav_bar.Controls.Add(this.logout_btn);
            this.nav_bar.Controls.Add(this.info_btn);
            this.nav_bar.Controls.Add(this.anas_btn);
            this.nav_bar.Controls.Add(this.hamdy_btn);
            this.nav_bar.Controls.Add(this.khaled_btn);
            this.nav_bar.Controls.Add(this.home_btn);
            this.nav_bar.Controls.Add(this.trans_img);
            this.nav_bar.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.nav_bar.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.nav_bar.Location = new System.Drawing.Point(11, 12);
            this.nav_bar.Name = "nav_bar";
            this.nav_bar.Radius = 18;
            this.nav_bar.Size = new System.Drawing.Size(89, 625);
            this.nav_bar.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.AnimationHoverSpeed = 0.07F;
            this.logout_btn.AnimationSpeed = 0.03F;
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.logout_btn.BorderColor = System.Drawing.Color.Black;
            this.logout_btn.CheckedBaseColor = System.Drawing.Color.White;
            this.logout_btn.CheckedBorderColor = System.Drawing.Color.RosyBrown;
            this.logout_btn.CheckedForeColor = System.Drawing.Color.White;
            this.logout_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.CheckedImage")));
            this.logout_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logout_btn.FocusedColor = System.Drawing.Color.Empty;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logout_btn.ImageSize = new System.Drawing.Size(37, 37);
            this.logout_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.logout_btn.Location = new System.Drawing.Point(15, 560);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.logout_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logout_btn.OnHoverForeColor = System.Drawing.Color.Violet;
            this.logout_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.OnHoverImage")));
            this.logout_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.logout_btn.OnPressedColor = System.Drawing.Color.Black;
            this.logout_btn.Radius = 18;
            this.logout_btn.Size = new System.Drawing.Size(65, 54);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.UseTransfarantBackground = true;
            this.logout_btn.Click += new System.EventHandler(this.exit);
            // 
            // info_btn
            // 
            this.info_btn.AnimationHoverSpeed = 0.07F;
            this.info_btn.AnimationSpeed = 0.03F;
            this.info_btn.BackColor = System.Drawing.Color.Transparent;
            this.info_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.info_btn.BorderColor = System.Drawing.Color.Black;
            this.info_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.info_btn.CheckedBaseColor = System.Drawing.Color.White;
            this.info_btn.CheckedBorderColor = System.Drawing.Color.RosyBrown;
            this.info_btn.CheckedForeColor = System.Drawing.Color.White;
            this.info_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("info_btn.CheckedImage")));
            this.info_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.info_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.info_btn.FocusedColor = System.Drawing.Color.Empty;
            this.info_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.info_btn.ForeColor = System.Drawing.Color.White;
            this.info_btn.Image = ((System.Drawing.Image)(resources.GetObject("info_btn.Image")));
            this.info_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.info_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.info_btn.Location = new System.Drawing.Point(10, 442);
            this.info_btn.Name = "info_btn";
            this.info_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.info_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.info_btn.OnHoverForeColor = System.Drawing.Color.Violet;
            this.info_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("info_btn.OnHoverImage")));
            this.info_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.info_btn.OnPressedColor = System.Drawing.Color.Black;
            this.info_btn.Radius = 18;
            this.info_btn.Size = new System.Drawing.Size(79, 66);
            this.info_btn.TabIndex = 1;
            this.info_btn.UseTransfarantBackground = true;
            this.info_btn.Click += new System.EventHandler(this.info);
            // 
            // anas_btn
            // 
            this.anas_btn.AnimationHoverSpeed = 0.07F;
            this.anas_btn.AnimationSpeed = 0.03F;
            this.anas_btn.BackColor = System.Drawing.Color.Transparent;
            this.anas_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.anas_btn.BorderColor = System.Drawing.Color.Black;
            this.anas_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.anas_btn.CheckedBaseColor = System.Drawing.Color.White;
            this.anas_btn.CheckedBorderColor = System.Drawing.Color.RosyBrown;
            this.anas_btn.CheckedForeColor = System.Drawing.Color.White;
            this.anas_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("anas_btn.CheckedImage")));
            this.anas_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.anas_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anas_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.anas_btn.FocusedColor = System.Drawing.Color.Empty;
            this.anas_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.anas_btn.ForeColor = System.Drawing.Color.White;
            this.anas_btn.Image = ((System.Drawing.Image)(resources.GetObject("anas_btn.Image")));
            this.anas_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anas_btn.ImageSize = new System.Drawing.Size(42, 42);
            this.anas_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.anas_btn.Location = new System.Drawing.Point(10, 342);
            this.anas_btn.Name = "anas_btn";
            this.anas_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.anas_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.anas_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.anas_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("anas_btn.OnHoverImage")));
            this.anas_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.anas_btn.OnPressedColor = System.Drawing.Color.Black;
            this.anas_btn.Radius = 18;
            this.anas_btn.Size = new System.Drawing.Size(79, 66);
            this.anas_btn.TabIndex = 1;
            this.anas_btn.UseTransfarantBackground = true;
            this.anas_btn.Click += new System.EventHandler(this.anas);
            // 
            // hamdy_btn
            // 
            this.hamdy_btn.AnimationHoverSpeed = 0.07F;
            this.hamdy_btn.AnimationSpeed = 0.03F;
            this.hamdy_btn.BackColor = System.Drawing.Color.Transparent;
            this.hamdy_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.hamdy_btn.BorderColor = System.Drawing.Color.Black;
            this.hamdy_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.hamdy_btn.CheckedBaseColor = System.Drawing.Color.White;
            this.hamdy_btn.CheckedBorderColor = System.Drawing.Color.RosyBrown;
            this.hamdy_btn.CheckedForeColor = System.Drawing.Color.White;
            this.hamdy_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("hamdy_btn.CheckedImage")));
            this.hamdy_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.hamdy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamdy_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hamdy_btn.FocusedColor = System.Drawing.Color.Empty;
            this.hamdy_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hamdy_btn.ForeColor = System.Drawing.Color.White;
            this.hamdy_btn.Image = ((System.Drawing.Image)(resources.GetObject("hamdy_btn.Image")));
            this.hamdy_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hamdy_btn.ImageSize = new System.Drawing.Size(34, 34);
            this.hamdy_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.hamdy_btn.Location = new System.Drawing.Point(10, 242);
            this.hamdy_btn.Name = "hamdy_btn";
            this.hamdy_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.hamdy_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.hamdy_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.hamdy_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("hamdy_btn.OnHoverImage")));
            this.hamdy_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.hamdy_btn.OnPressedColor = System.Drawing.Color.Black;
            this.hamdy_btn.Radius = 18;
            this.hamdy_btn.Size = new System.Drawing.Size(79, 66);
            this.hamdy_btn.TabIndex = 1;
            this.hamdy_btn.UseTransfarantBackground = true;
            this.hamdy_btn.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // khaled_btn
            // 
            this.khaled_btn.AnimationHoverSpeed = 0.07F;
            this.khaled_btn.AnimationSpeed = 0.03F;
            this.khaled_btn.BackColor = System.Drawing.Color.Transparent;
            this.khaled_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.khaled_btn.BorderColor = System.Drawing.Color.Black;
            this.khaled_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.khaled_btn.CheckedBaseColor = System.Drawing.Color.White;
            this.khaled_btn.CheckedBorderColor = System.Drawing.Color.RosyBrown;
            this.khaled_btn.CheckedForeColor = System.Drawing.Color.White;
            this.khaled_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("khaled_btn.CheckedImage")));
            this.khaled_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.khaled_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.khaled_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.khaled_btn.FocusedColor = System.Drawing.Color.Empty;
            this.khaled_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.khaled_btn.ForeColor = System.Drawing.Color.White;
            this.khaled_btn.Image = ((System.Drawing.Image)(resources.GetObject("khaled_btn.Image")));
            this.khaled_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.khaled_btn.ImageSize = new System.Drawing.Size(37, 37);
            this.khaled_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.khaled_btn.Location = new System.Drawing.Point(10, 142);
            this.khaled_btn.Name = "khaled_btn";
            this.khaled_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.khaled_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.khaled_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.khaled_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("khaled_btn.OnHoverImage")));
            this.khaled_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.khaled_btn.OnPressedColor = System.Drawing.Color.Black;
            this.khaled_btn.Radius = 18;
            this.khaled_btn.Size = new System.Drawing.Size(79, 66);
            this.khaled_btn.TabIndex = 1;
            this.khaled_btn.UseTransfarantBackground = true;
            this.khaled_btn.Click += new System.EventHandler(this.gunaGradient2Panel2_Click);
            // 
            // home_btn
            // 
            this.home_btn.AnimationHoverSpeed = 0.07F;
            this.home_btn.AnimationSpeed = 0.03F;
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.home_btn.BorderColor = System.Drawing.Color.Black;
            this.home_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.home_btn.Checked = true;
            this.home_btn.CheckedBaseColor = System.Drawing.Color.White;
            this.home_btn.CheckedBorderColor = System.Drawing.Color.RosyBrown;
            this.home_btn.CheckedForeColor = System.Drawing.Color.White;
            this.home_btn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("home_btn.CheckedImage")));
            this.home_btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.home_btn.FocusedColor = System.Drawing.Color.Empty;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.home_btn.ImageSize = new System.Drawing.Size(33, 33);
            this.home_btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.home_btn.Location = new System.Drawing.Point(10, 42);
            this.home_btn.Name = "home_btn";
            this.home_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.home_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.home_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.home_btn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("home_btn.OnHoverImage")));
            this.home_btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.home_btn.OnPressedColor = System.Drawing.Color.Black;
            this.home_btn.Radius = 18;
            this.home_btn.Size = new System.Drawing.Size(79, 66);
            this.home_btn.TabIndex = 1;
            this.home_btn.UseTransfarantBackground = true;
            this.home_btn.Click += new System.EventHandler(this.home);
            // 
            // trans_img
            // 
            this.trans_img.Image = ((System.Drawing.Image)(resources.GetObject("trans_img.Image")));
            this.trans_img.Location = new System.Drawing.Point(71, 22);
            this.trans_img.Name = "trans_img";
            this.trans_img.Size = new System.Drawing.Size(61, 107);
            this.trans_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trans_img.TabIndex = 0;
            this.trans_img.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 658);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.nav_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trans_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel container;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaGradient2Panel nav_bar;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton home_btn;
        private System.Windows.Forms.PictureBox trans_img;
        private Guna.UI.WinForms.GunaAdvenceButton info_btn;
        private Guna.UI.WinForms.GunaAdvenceButton anas_btn;
        private Guna.UI.WinForms.GunaAdvenceButton hamdy_btn;
        private Guna.UI.WinForms.GunaAdvenceButton khaled_btn;
        private Guna.UI.WinForms.GunaAdvenceButton logout_btn;
    }
}

