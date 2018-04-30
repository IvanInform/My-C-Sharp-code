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
    
    public partial class RunningStatic : Form
    {
        public RunningStatic()
        {
            InitializeComponent();
            rand = new Random();
        panel = new Panel();
            panel.SetBounds(10, 10, 50, 50);
            panel.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(panel);
            xcoord = panel.Location.X;
            ycoord = panel.Location.Y;
            //panel.MouseClick += new MouseEventHandler(panel_MouseDown);
            Rectangle smallrect = new Rectangle( xcoord,ycoord, panel.Size.Width,panel.Size.Height);
            rect = Rectangle.Inflate(smallrect,+10, +10);
        }
        #region
        //private void panel_MouseDown(object sender, MouseEventArgs e)
        //{
            //if (e.Button == MouseButtons.Left)
            //{

            //    //Point p = this.PointToClient(System.Windows.Forms.Control.MousePosition);
            //    Point p = this.PointToClient(Cursor.Position);
            //    //Rectangle rectangle = new Rectangle(xcoord, ycoord, panel.Size.Width, panel.Size.Height);
            //    if (rect.Contains(p))
            //    {
            //        Panel oldpanel = panel;
                    
            //        while (rect.Contains(new Point(xcoord, ycoord)) == true)
            //        {
            //            xcoord = rand.Next(0, 100);
            //            ycoord = rand.Next(0, 100);
            //        }

                 
            //        panel = new Panel();
            //        panel.SetBounds(xcoord, ycoord, oldpanel.Size.Width, oldpanel.Size.Height);
                  
            //        panel.Location = new Point(xcoord, ycoord);
            //        panel.Size = new Size(50, 50);
            //        panel.BackColor = oldpanel.BackColor;
            //        oldpanel.Dispose();
            //        this.Controls.Add(panel);
            //        panel.MouseClick += new MouseEventHandler(panel_MouseDown);
                   
            //    }
            //}
        //}
        #endregion



        public  Panel panel { get; set; }

Random rand = null;
private int xcoord;
private int ycoord;
private Rectangle rect;

private void RunningStatic_MouseDown(object sender, MouseEventArgs e)
{
    
}

private void RunningStatic_MouseMove(object sender, MouseEventArgs e)
{
    Point p = new Point(e.X, e.Y);
    this.Text = "x=" + e.X.ToString() + "y=" + e.Y.ToString();
    if (rect.Contains(p)) {
        Panel oldpanel = panel;

        while (rect.Contains(new Point(xcoord, ycoord)) == true)
        {
            xcoord = rand.Next(0, this.ClientRectangle.Width-50);
            ycoord = rand.Next(0, this.ClientRectangle.Height-50);
        }


        panel = new Panel();
        panel.SetBounds(xcoord, ycoord, oldpanel.Size.Width, oldpanel.Size.Height);

        panel.Location = new Point(xcoord, ycoord);
        panel.Size = new Size(50, 50);
        panel.BackColor = oldpanel.BackColor;
        oldpanel.Dispose();
        this.Controls.Add(panel);
        Rectangle smrect = new Rectangle(panel.Location.X, panel.Location.Y, panel.Size.Width,
                       panel.Size.Height);
        rect = Rectangle.Inflate(smrect, +10, +10);
    }
}
    
    }

}
