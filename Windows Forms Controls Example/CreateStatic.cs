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
    public partial class CreateStatic : Form
    {
        List<Panel> panels = null;
        Point p;
        string str;
        Rectangle r;
        public CreateStatic()
        {
            InitializeComponent();
            panels = new List<Panel>();
            p = new System.Drawing.Point(0, 0);
            r = new Rectangle(p, new Size(0, 0));
            str = string.Empty;
            
        }

        private void CreateStatic_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void CreateStatic_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CreateStatic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                p = new Point(e.X, e.Y);
            
            }
          
        }

        private void CreateStatic_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { 
            r=new Rectangle(p,new Size((e.X-p.X), (e.Y-p.Y)));
           Panel panel = new Panel();
           panel.Bounds = r;
           panel.BackColor = System.Drawing.Color.Purple;
           panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
           panel.MouseDown += new MouseEventHandler(PanelmouseClick);
           panel.MouseDoubleClick += new MouseEventHandler(Panel_MouseDoubleClick);
            this.Controls.Add(panel);
            panels.Add(panel);
            }
        }

        private void Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point pt1 = this.PointToClient(System.Windows.Forms.Control.MousePosition);
            for (int i = panels.Count - 1; i >= 0; i--)
            {
                Size size = new Size(panels[i].Width, panels[i].Height);
                Point pt2 = new Point(panels[i].Location.X, panels[i].Location.Y);
                Rectangle rect = new Rectangle(pt2, size);
                if (rect.Contains(pt1))
                {
                   
                    this.Controls.Remove(panels[i]); 
                    panels.Remove(panels[i]);
                }

            }
        }

        private void PanelmouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (panels.Count != 0)
                {
                    foreach (Panel item in panels)
                    {

                        Size size = new Size(item.Width, item.Height);
                        Point point = new Point(item.Location.X, item.Location.Y);
                        Rectangle rect = new Rectangle(point, size);
                        if (rect.Contains(this.PointToClient(Cursor.Position)))
                        {
                            str = " x=" + item.Location.X.ToString() +
                                " y= " + item.Location.Y.ToString() + " площадь= " +
                               Convert.ToString(item.Size.Width + item.Size.Height);
                            this.Text = str;
                        }
                    }

                }

            }
        }

        private void CreateStatic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }


    }
}
