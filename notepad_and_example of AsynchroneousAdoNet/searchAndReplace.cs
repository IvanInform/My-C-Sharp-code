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
    public partial class searchAndReplace : Form
    {
        Notepad pointer = null;
        string searchedtxt;
        string replacetxt;
        string corrected;
        public searchAndReplace(Notepad obj)
        {
            InitializeComponent();
            searchedtxt = obj.text.Text;
            pointer = obj;
        }

        private void btnFindReplace_Click(object sender, EventArgs e)
        {
            replacetxt = txtReplace.Text;
            int pos = searchedtxt.IndexOf(txtFind.Text);
            if (pos != -1)
            {
                corrected = pointer.text.Text.Replace(txtFind.Text, replacetxt);
                pointer.text.Text = String.Copy(corrected);
            }
            else {
                MessageBox.Show("Текст не найден!");
            }
            pointer = null;
            searchedtxt = null;
            this.Close();
        }
    }
}
