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
    public partial class ThreadWork : Form
    {
        public ThreadWork()
        {
            InitializeComponent();
        }
        private delegate void FillTextDelegate(SqlDataReader reader);
        private bool isExecuting=false;
        private bool isExecuting2 = false;
        private SqlConnection connection=null;
        private SqlConnection connection2 = null;

        private delegate void DisplayStatusDelegate(string Text);
        private void DisplayStatus(string Text) {
            this.textBox1.Text = Text;
        }
        private void DisplayStatus2(string Text) {
            this.textBox2.Text = Text;
        }
        private void FillText2(SqlDataReader reader)
        {
            int totallen = 0;
            try
            {
                DataTable table = new DataTable();
                table.Load(reader);
                foreach (DataRow dr in table.Rows)
                {
                    totallen += dr["FirstName"].ToString().Length+dr["LastName"].ToString().Length;
                }
                DisplayStatus2(totallen.ToString());
            }
            catch (Exception ex)
            {

                DisplayStatus2(string.Format("Ready (last attemp failed: {0})", ex.Message));
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection2 != null)
                {
                    connection2.Close();
                }
            }
        }
        private void FillText(SqlDataReader reader) {
             int totallen=0;
             try
             {
                 DataTable table = new DataTable();
                 table.Load(reader);
                 foreach (DataRow dr in table.Rows)
                 {
                     totallen += dr["Title"].ToString().Length;
                 }
                 DisplayStatus(totallen.ToString());
             }
             catch (Exception ex)
             {

                 DisplayStatus(string.Format("Ready (last attemp failed: {0})", ex.Message));
             }
             finally {
                 if (reader != null) {
                     reader.Close();
                 }
                 if (connection != null) {
                     connection.Close();
                 }
             }
        }
        private string GetConnectionString() { 
        string str=System.Configuration.ConfigurationManager.ConnectionStrings["MyLibrary"].ConnectionString;
        return str + ";Asynchronous Processing=true";
        }
        private void HandleCallback2(IAsyncResult result) {
            try
            {
                SqlCommand command = (SqlCommand)result.AsyncState;
                SqlDataReader reader = command.EndExecuteReader(result);
                FillTextDelegate del = new FillTextDelegate(FillText2);
                this.Invoke(del, reader);
            }
            catch (Exception ex)
            {

                this.Invoke(new DisplayStatusDelegate(DisplayStatus2), "Error: " + ex.Message);
            }
            finally
            {
                isExecuting2 = false;
            }
        
        }
        private void HandleCallback(IAsyncResult result) {
            try
            {
                SqlCommand command = (SqlCommand)result.AsyncState;
                SqlDataReader reader = command.EndExecuteReader(result);
                FillTextDelegate del = new FillTextDelegate(FillText);
                this.Invoke(del, reader);
            }
            catch (Exception ex)
            {

                this.Invoke(new DisplayStatusDelegate(DisplayStatus), "Error: " + ex.Message);
            }
            finally {
                isExecuting = false;
            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isExecuting||isExecuting2)
            {
                MessageBox.Show(this, "Already executing.Please wait until the current query" +
                    "has completed");
            }
            else {
                SqlCommand command = null;
                SqlCommand command2 = null;
                try
                {
                    DisplayStatus("Connecting...");
                    DisplayStatus2("Connecting...");
                    string str = GetConnectionString();
                    connection=new SqlConnection(str);
                    connection2 = new SqlConnection(str);
                    command=new SqlCommand("WAITFOR DELAY '0:0:5';"+
                    "select * from Books", connection);
                    command2 = new SqlCommand("WAITFOR DELAY '0:0:5';" +
                    "select * from Authors", connection2);
                    
                    connection.Open();
                    connection2.Open();
                    DisplayStatus("Executing...");
                    isExecuting = true;
                    AsyncCallback callback = new AsyncCallback(HandleCallback);
                    command.BeginExecuteReader(callback, command);
                    AsyncCallback callback2 = new AsyncCallback(HandleCallback2);
                    command2.BeginExecuteReader(callback2, command2);
                }
                catch (Exception ex)
                {

                    DisplayStatus("Error: " + ex.Message);
                    if (connection != null)
                    {
                        connection.Close();
                        
                    }
                    if (connection2 != null) { connection2.Close(); }
                }
            
            }
                
        }

        private void ThreadWork_Load(object sender, System.EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(ThreadWork_FormClosing);
        }

        private void ThreadWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExecuting||isExecuting2)
            {
                MessageBox.Show(this, "Cannot close the form until " +
                    "the pending asynchronous command has completed. Please wait...");
                e.Cancel = true;
            }
        }


      
    }
}
