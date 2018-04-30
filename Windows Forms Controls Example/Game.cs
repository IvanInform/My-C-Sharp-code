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
    public partial class Game : Form
    {
        int[] array=null;
        int first;
        int last;
        int middle;
        int count;
        bool victory;
        bool endGame;
        public Game()
        {
            
            InitializeComponent();
            
            array = new int[2000];
            for (int i = 0; i < 2000; i++) {
                array[i] = i + 1;
            }
            count = 0;
            first = 0;
            last = 1999;
            middle = (first + last) / 2;
            victory = false;
            endGame = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            result = MessageBox.Show("Давай Играть! ", "Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            while (endGame!=true)
            {
                while (first <= last || victory != true)
                {
                    string message = "Номер равен" + array[middle].ToString();
                    result = MessageBox.Show(message, "Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Cancel) {
                        break;
                    }
                    if (result == DialogResult.Yes)
                    {
                        victory = true; count++; endGame = true; break;
                    }
                    message = "Число больше чем " + array[middle].ToString();
                    result = MessageBox.Show(message, "Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Cancel)
                    {
                        endGame = true; break;
                    }
                    if (result == DialogResult.Yes)
                    {
                        first = middle + 1;
                    }
                    else
                    {
                        last = middle - 1;

                    }
                    middle = (first + last) / 2;
                    count++;
                }

                if (first > last)
                {
                    MessageBox.Show("Ваше число не в рамках от 0 до 2000", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string message = "Ваше число " + array[middle] + " Вы пытались " + count.ToString() + " раз";
                    MessageBox.Show(message, "Молодец", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    victory = true;
                    endGame = true;
                }
            }
            result = MessageBox.Show("Хотите сыграть снова?", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                first = 0;
                last = 1999;
                middle = (first + last) / 2;
                victory = false;
                endGame = false;
            
            }
        }
    }
}
