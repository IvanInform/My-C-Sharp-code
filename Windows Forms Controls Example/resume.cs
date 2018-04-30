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
    public partial class resume : Form
    {
        string[] myresume=null;
        StringBuilder str = null;
        int average = 0;
       
        public resume()
        {
            InitializeComponent();
            myresume = new string[3];
            myresume[0] = "Я родилась тогда-то";
            myresume[1] = "Пошла в школу 1990";
            myresume[2] = "Закончила университет. Работала в банке \"Несите ваши деньги\"";
            str = new StringBuilder();
            foreach (string item in myresume) {
                str.Append(item);
            }
            average = str.ToString().Count()/3;
        }
        //на форме кнопка, вот ее обработчик событий
        private void button1_Click(object sender, EventArgs e)
        {

            for (int i=0;i<3;i++){

                MessageBox.Show(myresume[i], "Мое Резюме", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //сдесь есть label на форме 
            label1.Text = average.ToString();
            
        }

     
    }
}
