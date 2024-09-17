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

namespace InternProject
{
    public partial class StockForm : Form
    {
        //MySQL Connection adress
        string connAdress = "server=127.0.0.1;uid=root;port=3306;pwd=12345;database=my_project;";
        public StockForm()
        {
            InitializeComponent();
        }

        //Back Button
        private void stockBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //Close the page
        private void stockClose_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Works when the form is loaded
        private void StockForm_Load(object sender, EventArgs e)
        {
            string Query = "select * from materials";

            //Get data and write it to DataGridView
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {

                try
                {
                    connection.Open();
                    MySqlCommand commmand = new MySqlCommand(Query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGW_MalList_Stokcu.DataSource = dataTable;
                    connection.Close();

                    //Change the columns name
                    DGW_MalList_Stokcu.Columns["material_id"].HeaderText = "Malzeme ID";
                    DGW_MalList_Stokcu.Columns["name"].HeaderText = "Malzeme Adı";
                    DGW_MalList_Stokcu.Columns["type"].HeaderText = "Tipi";
                    DGW_MalList_Stokcu.Columns["quantity"].HeaderText = "Stok Adedi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }


            }

            //Receive data and write User info
            using (MySqlConnection connection1 = new MySqlConnection(connAdress))
            {
                try
                {
                    connection1.Open();
                    string query = "SELECT user_id, username, role FROM users WHERE username = 'Hüseyin'";

                    MySqlCommand cmd = new MySqlCommand(query, connection1);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Label_id.Text = "ID: " + reader["user_id"].ToString();
                        Label_username.Text = "K.Adı: " + reader["username"].ToString();
                        Label_role.Text = "Görevi: " + reader["role"].ToString();
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

        //Add new material
        private void add_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                try
                {
                    connection.Open();

                    string material_id = idTxt.Text;
                    string name = nameTxt.Text;
                    string type = typeTxt.Text;
                    string quantity = quantityTxt.Text;

                    string query = "insert into materials(material_id,name,type,quantity) values (@material_id,@name,@type,@quantity)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@material_id", material_id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ekleme İşlemi Başarılı");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }

            //Clear the textboxs
            idTxt.Clear();
            nameTxt.Clear();
            typeTxt.Clear();
            quantityTxt.Clear();

        }

        //Delete select material
        private void delete_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                try
                {
                    connection.Open();

                    string material_id = idTxt.Text;

                    //string name = nameTxt.Text;
                    //string type = typeTxt.Text;
                    //string quantity = quantityTxt.Text;

                    string query = "SET FOREIGN_KEY_CHECKS = 0;\r\n" +
                        "DELETE FROM materials WHERE material_id = @material_id;\r\n" +
                        "SET FOREIGN_KEY_CHECKS = 1;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@material_id", material_id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Silme İşlemi Başarılı");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }

            //Clear the textboxs
            idTxt.Clear();

        }
        //Update select material
        private void update_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                try
                {
                    connection.Open();

                    string material_id = idTxt.Text;
                    //string name = nameTxt.Text;
                    //string type = typeTxt.Text;
                    string quantity = quantityTxt.Text;

                    string query = "update materials set quantity=quantity+@quantity where material_id=@material_id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@material_id", material_id);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Güncelleme İşlemi Başarılı");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }

            //Clear the textboxs
            idTxt.Clear();
            quantityTxt.Clear();
        }

        //Refresh the page
        private void refresh_button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //This method refresh the page
        private void LoadData()
        {
            
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                string query = "SELECT * FROM Materials";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGW_MalList_Stokcu.DataSource = dataTable;
            }
        }
    }
}
