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
    public partial class ImageDataSource : Form
    {
        public ImageDataSource()
        {
            InitializeComponent();
        }

        private void ImageDataSource_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageDataSet.ImageTable' table. You can move, or remove it, as needed.
            this.imageTableTableAdapter.Fill(this.imageDataSet.ImageTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Images only. |*.jpg; *.jpeg; *.png;*.gif;";
            DialogResult result = fd.ShowDialog();
            pictureBox1.Image = Image.FromFile(fd.FileName);
            textBox2.Text = fd.FileName;
        }
    }
}
