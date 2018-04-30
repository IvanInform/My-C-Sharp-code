using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFactoryProvider
{
    public partial class SearchBox : Form
    {
         Notepad pointer = null;
         string searchedtxt;
       public SearchBox( Notepad obj2){
           InitializeComponent();
              pointer = obj2;
              searchedtxt = pointer.text.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tosearch = textBox1.Text;

            int pos = searchedtxt.IndexOf(textBox1.Text);
            if (pos != -1)
            {
               
                pointer.text.SelectionStart = pos;
                pointer.text.SelectionLength = textBox1.Text.Length;
                
            }
            else {
                MessageBox.Show("No text Found!");
                           }
            /* 
             Necessary to nullify pointers not to erase objects in parent form
             */
            pointer = null;
            searchedtxt = null;
            this.Close();
        }

    }
}
