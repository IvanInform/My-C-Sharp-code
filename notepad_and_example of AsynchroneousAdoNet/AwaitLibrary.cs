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
using System.Data.SqlClient;




namespace DBFactoryProvider
{
    public partial class AwaitLibrary : Form
    {
        SqlConnection conn = null;
        string connectionString = "";
        DataTable table = null;
        List<string> Authors = null;
        string defaultCommand;
        bool IsCombobox;
        int bookCount;
        public AwaitLibrary()
        {
            InitializeComponent();
            table = new DataTable();
            Authors = new List<string>();
            IsCombobox = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connectionString;
            await conn.OpenAsync();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "WAITFOR DELAY '0:0:5';";
            cmd.CommandText += textBox1.Text.ToString();
            if (cmd.CommandText.ToLower().Contains("select * from Books".ToLower())){
            
            cmd.CommandText+=";select a.LastName from Authors as a, Books as b where a.Id=b.AuthorId order by a.LastName DESC";
            Authors.Clear();
            IsCombobox = true;
            }
            
            Authors.Clear();

            try
            {
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    int line = 0;
                    int count = 0;
                    do
                    {


                        if (count == 1 && IsCombobox == true)
                        {

                            while (await reader.ReadAsync())
                            {
                                Authors.Add(reader["LastName"].ToString());

                            }
                        }
                        else
                        {
                            table = new DataTable();
                            while (await reader.ReadAsync())
                            {
                                if (line == 0)
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        table.Columns.Add(reader.GetName(i));

                                    } line++;

                                }
                                DataRow row = table.NewRow();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = await reader.GetFieldValueAsync<Object>(i);
                                }
                                table.Rows.Add(row);
                            }
                        }
                        count++;
                    } while (reader.NextResult());

                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
                foreach (var item in Authors)
                {
                    comboBox1.Items.Add(item);
                }
                if (conn.State == ConnectionState.Open) { conn.Close(); }
                comboBox1.Items.Insert(0, "Выберите Автора");
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open) { conn.Close(); }
                return;
            }
          
            
               
        }

        private void AwaitLibrary_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyLibrary"].ConnectionString;
            conn = new SqlConnection(connectionString);
            if (connectionString == null) {
                MessageBox.Show("В конфигурационном файле нет требуемой строки подключения");

            }
        }
        private Task<object> getDataAsync(SqlCommand cmd) {
            return Task.Run<object>(() => { return cmd.ExecuteScalarAsync(); });
        }
        private async void  comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = comboBox1.SelectedItem.ToString();
            if (conn.State == ConnectionState.Open) { conn.Close(); }
            conn.ConnectionString = connectionString;
            SqlCommand cmd = null;
            try
            {
                await conn.OpenAsync();
                cmd = conn.CreateCommand();
                cmd.CommandText = "WAITFOR DELAY '0:0:5';";
                cmd.CommandText += "select count(*) from Books as b, Authors as a where a.Id=b.AuthorId and a.LastName=" + "'"+value+"'";
                bookCount = Convert.ToInt32( await cmd.ExecuteScalarAsync());
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }
            label1.Text = bookCount.ToString(); 
        }

    }
}
