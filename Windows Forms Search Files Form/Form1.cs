using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessonThree
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            
        }
        public Form1(Form1 f) {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Yellow;
            Button button2=new Button{
            Location=new Point{ X=this.Width/2, 
            Y=this.Height/2}
            };
            button2.Text = "Close";
            button2.Click += button2_Click;
            this.Controls.Add(button2);
            this.Load+=Form1_Load;
            this.MouseDown+=Form1_MouseDown;
            this.MouseMove+=Form1_MouseMove;

        }
        private void button1_Click(object sender, EventArgs e) {
            Form1 f = new Form1(this);
            f.Show();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void Form1_Load(object sender, EventArgs e) {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                moveStart = new Point(e.X, e.Y);
            }
        
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if ((e.Button & MouseButtons.Left) != 0) {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + deltaPos.X,
                this.Location.Y + deltaPos.Y);
                            
            
            }
        
        }
        Point moveStart;
    }
}
