using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLesson
{
    public partial class rectangle : Form
    {
        Rectangle r; 
        public rectangle()
        {

            InitializeComponent();

            r = this.ClientRectangle;
            r.Inflate(-30,-30);


        }

        private void rectangle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                this.Close();
            }
             if (e.Button == MouseButtons.Left) {
                Point p = new Point(e.X,e.Y);
                
                if (r.Contains(p))
                {
                    MessageBox.Show("Click is within client rectangle");

                }
                else {
                    MessageBox.Show("Click is outside rectangle");
                }
            
            }
             if (e.Button == MouseButtons.Right) {
                 Rectangle r = this.ClientRectangle;
                 this.Text = "Клиенское окно x=" + r.Width.ToString() + " y= " + r.Height.ToString();
             }
        }


        private void rectangle_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            string str = "x=" + e.X + " y=" + e.Y;
            this.Text = str;
        }
    }
}
