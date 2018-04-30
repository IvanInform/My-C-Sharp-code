using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
using System.Configuration;


namespace DBFactoryProvider
{
    public partial class Form1 : Form
    {
        DbConnection conn = null;
        DbProviderFactory fact = null;
        string providerName = "";
        public Form1()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
            this.dataGridView1.Width = 500;
            this.dataGridView1.Height = 300;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable t = DbProviderFactories.GetFactoryClasses();
            dataGridView1.DataSource = t;
       
            comboBox1.Items.Clear();
            foreach (DataRow dr in t.Rows) {
                comboBox1.Items.Add(dr["InvariantName"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fact = DbProviderFactories.GetFactory(comboBox1.SelectedItem.ToString());
            conn = fact.CreateConnection();
            providerName = GetConnectionStringByProvider(comboBox1.SelectedItem.ToString());
            textBox1.Text = providerName;
        }

        private string GetConnectionStringByProvider(string p)
        {
            string returnValue = null;
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null) {
                foreach (ConnectionStringSettings cs in settings) {
                    if (cs.ProviderName == p) {
                        returnValue = cs.ConnectionString;
                        break;
                    }
                
                }
            } return returnValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = textBox1.Text;
            DbDataAdapter adapter = fact.CreateDataAdapter();
            adapter.SelectCommand = conn.CreateCommand();
            adapter.SelectCommand.CommandText = textBox2.Text.ToString();
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }



    }
}
