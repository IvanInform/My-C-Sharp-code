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
    public partial class bindingsource : Form
    {
        public bindingsource()
        {
            InitializeComponent();
            
        }

        private void bindingsource_Load(object sender, EventArgs e)
        {
            bindingSource1.Add(new user() { UserName = "Ivan", UserId = 1 });
            bindingSource1.Add(new user() { UserName = "Peter", UserId = 2 });
            bindingSource1.Add(new user() { UserName = "Grisha", UserId = 3 });
            bindingSource1.Add(new user() { UserName = "Masha", UserId = 4 });
            bindingSource1.Add(new user() { UserName = "Sasha", UserId = 5 });
        }
    }
}
