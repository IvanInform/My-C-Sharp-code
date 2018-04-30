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
    public partial class DateSpan : Form
    {
        private List<RadioButton> radiobuttons;
        private string str;
        public DateSpan()
        {
            InitializeComponent();
            this.Width = 700;
            radiobuttons=new List<RadioButton>();
            radiobuttons.Add(radioButton1);
            radiobuttons.Add(radioButton2);
            radiobuttons.Add(radioButton3);
            radiobuttons.Add(radioButton4);
            radiobuttons.Add(radioButton5);
            radioButton1.Checked=true;
            str = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int years;
            int months;
            DateTime first;
            DateTime second;
            if (DateTime.TryParse(textBox1.Text, out first) && DateTime.TryParse(textBox2.Text, out second))
            {
                DateTime difference;
               
                TimeSpan interval = second - first;
                foreach (RadioButton button in radiobuttons)
                {
                    if (button.Checked)
                    {
                        str = button.Text;

                    }

                }

                string monthstr="";
                try
                {
                difference = DateTime.MinValue + interval;
               years = difference.Year - 1;
               months = difference.Month - 1;
                monthstr = string.Format("{0}/{1}",months, 12);
                switch (str)
                {
                    case "Годы":

                        label3.Text = (years == 0 ? string.Format("Разница в годах:{0}", monthstr) : string.Format("Разница в годах:{0}", years));
                        break;
                    case "Месяцы":
                       months = difference.Month - 1+(years*12);
                        label3.Text = string.Format("Разница в месяцах:{0}", months);
                        break;
                    case "Дни":
                        
                        label3.Text = string.Format("Разница в днях:{0}", interval.TotalDays);
                        break;
                    case "Минуты":
                        label3.Text = string.Format("Разница в минутах:{0}", interval.TotalMinutes);
                        break;
                    case "Секунды":
                        label3.Text = string.Format("Разница в секундах:{0}", interval.TotalSeconds);
                        break;


                }
                }
                catch (Exception ex)
                {

                    label3.Text = ex.Message;
                } 

            }
            else {
                label3.Text = "Неправильный Формат Даты";
            }
        }
    }
}
