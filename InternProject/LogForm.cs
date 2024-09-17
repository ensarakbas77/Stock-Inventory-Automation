using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InternProject
{
    public partial class LogForm : Form
    {
        //Connection adress
        string connAdress = "server=127.0.0.1;uid=root;port=3306;pwd=12345;database=my_project;";
        public LogForm()
        {
            InitializeComponent();
        }

        //Close the page
        private void logClose_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Back button
        private void logBack_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            string Query = "select * from logview";

            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                connection.Open();
                MySqlCommand commmand = new MySqlCommand(Query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGW_logView_admin.DataSource = dataTable;
                connection.Close();

                //Change the columns name
                DGW_logView_admin.Columns["log_id"].HeaderText = "Log ID";
                DGW_logView_admin.Columns["username"].HeaderText = "Kullanıcı Adı";
                DGW_logView_admin.Columns["role"].HeaderText = "Görevi";
                DGW_logView_admin.Columns["name"].HeaderText = "Malzeme Adı";
                DGW_logView_admin.Columns["quantity"].HeaderText = "Stok Adedi";
                DGW_logView_admin.Columns["usage_reason"].HeaderText = "Kullanım Amacı";
                DGW_logView_admin.Columns["usage_date"].HeaderText = "Kullanım Tarihi";

            }
        }

        //Filter date
        private void search_button_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerUsageDate.Value;

            string query = "SELECT * FROM logview WHERE DATE(usage_date) = @selectedDate";

            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@selectedDate", selectedDate.ToString("yyyy-MM-dd"));

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGW_logView_admin.DataSource = dt;
            }
        }
    }
}
