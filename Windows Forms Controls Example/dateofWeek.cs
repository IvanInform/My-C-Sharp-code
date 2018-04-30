using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLesson
{
    public partial class dateofWeek : Form
    {
        public dateofWeek()
        {
            InitializeComponent();
            
        }
        private string russianDay(DayOfWeek date) {
        string str=string.Empty;
        switch (date)
        {
            case DayOfWeek.Monday:
                str = "Понедельник";
                break;
            case DayOfWeek.Friday:
                str = "Пятница";
                break;
            case DayOfWeek.Saturday:
                str = "Суббота";
                break;
            case DayOfWeek.Sunday:
                str = "Воскресенье";
                break;
            case DayOfWeek.Thursday:
                str = "Четверг";
                break;
            case DayOfWeek.Tuesday:
                str = "Вторник";
                break;
            case DayOfWeek.Wednesday:
                str = "Среда";
                break;

        }
        return str;
       }
        private void button1_Click(object sender, EventArgs e)
        {
           
            DateTime weekday;
            if (DateTime.TryParse(textBox1.Text, out weekday)) {

                label1.Text = String.Format(" Day of Week: {0}", russianDay(weekday.DayOfWeek));
            
            }

         
            
        }
    }
}
