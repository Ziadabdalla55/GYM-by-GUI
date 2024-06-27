using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsallny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void move_image(int x, int y)
        {
            trans_img.Location = new Point(x + 61, y - 20);
            trans_img.SendToBack();
        }

        private void add_us(UserControl us)
        {
            container.Controls.Clear();
            us.Dock = DockStyle.Fill;
            us.BringToFront();
            container.Controls.Add(us);
        }
        //khaled
        private void gunaGradient2Panel2_Click(object sender, EventArgs e)
        {
            int x, y;
            x = khaled_btn.Location.X;
            y = khaled_btn.Location.Y;
            move_image(x, y);

        }
        //hamdy
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = hamdy_btn.Location.X;
            y = hamdy_btn.Location.Y;
            move_image(x, y);
            home h = new home();
            add_us(h);
        }

        //anas
        private void anas(object sender, EventArgs e)
        {
            int x, y;
            x = anas_btn.Location.X;
            y = anas_btn.Location.Y;
            move_image(x, y);
        }

        private void info(object sender, EventArgs e)
        {
            int x, y;
            x = info_btn.Location.X;
            y = info_btn.Location.Y;
            move_image(x, y);
        }

        private void home(object sender, EventArgs e)
        {
            int x, y;
            x = home_btn.Location.X;
            y = home_btn.Location.Y;
            move_image(x, y);
        }

        private void gunaGradient2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
