using K4os.Compression.LZ4.Encoders;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InternProject
{
    public partial class MaintenanceForm : Form
    {
        //MySQL Connection adress
        string connAdress = "server=127.0.0.1;uid=root;port=3306;pwd=12345;database=my_project;";

        //Global variable for User info
        private string username;
        private string password;

        //Parameterised Constructor 
        public MaintenanceForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        public MaintenanceForm()
        {
            InitializeComponent();
        }

        //Back button
        private void bakımcıBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //Close the page
        private void bakımcıClose_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Works when the form is loaded
        private void Maintenance_Load(object sender, EventArgs e)
        {
            string Query = "select * from materials";

            //Get data and write it to DataGridView
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                connection.Open();
                MySqlCommand commmand = new MySqlCommand(Query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGW_Malzeme_Listele.DataSource = dataTable;
                connection.Close();

                //Change the columns name
                DGW_Malzeme_Listele.Columns["material_id"].HeaderText = "Malzeme ID";
                DGW_Malzeme_Listele.Columns["name"].HeaderText = "Malzeme Adı";
                DGW_Malzeme_Listele.Columns["type"].HeaderText = "Tipi";
                DGW_Malzeme_Listele.Columns["quantity"].HeaderText = "Stok Adedi";

            }

            //Receive data and write User info
            using (MySqlConnection connection1 = new MySqlConnection(connAdress))
            {
                try
                {
                    connection1.Open();
                    string query = "SELECT user_id, username, role FROM users WHERE username = @username and password=@password";

                    MySqlCommand cmd = new MySqlCommand(query, connection1);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        label1.Text = "ID: " + reader["user_id"].ToString();
                        label2.Text = "K.Adı: " + reader["username"].ToString();
                        label3.Text = "Görevi: " + reader["role"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri bulunamadı.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }

        }

        //Apply procedures
        private void apply_button_Click(object sender, EventArgs e)
        {
            //Write records to Log
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                string quantity;
                string material_id;
                try
                {
                    connection.Open();

                    material_id = idTxt.Text;
                    string user_id = userTxt.Text;
                    quantity = quantityTxt.Text;
                    string usage_reason = reasonTxt.Text;

                    string query = "insert into usagelogs(material_id,user_id,quantity,usage_reason,usage_date) values (@material_id,@user_id,@quantity,@usage_reason,NOW())";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@material_id", material_id);
                        command.Parameters.AddWithValue("@user_id", user_id);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@usage_reason", usage_reason);
                        command.ExecuteNonQuery();
                        MessageBox.Show("İşlem Gerçekleştirildi");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri Tabanı bağlantısında hata: " + ex.Message);
                }

                try
                {
                    connection.Open();

                    //Update stock quantity
                    string Query = "update materials set quantity=quantity+@quantity where material_id=@material_id";
                    using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                    {
                        quantity = quantityTxt.Text;
                        material_id = idTxt.Text;
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@material_id", material_id);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            //Clear the textboxs
            userTxt.Clear();
            idTxt.Clear();
            quantityTxt.Clear();
            reasonTxt.Clear();

        }

        //Refresh the page
        private void refresh_button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //Refresh method
        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                string query = "SELECT * FROM Materials";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGW_Malzeme_Listele.DataSource = dataTable;
            }
        }
    }
}
