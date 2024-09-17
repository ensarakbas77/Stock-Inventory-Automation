using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace InternProject
{
    public partial class ComputersMaintenanceForm : Form
    {
        //Connection adress
        string connAdress = "server=127.0.0.1;uid=root;port=3306;pwd=12345;database=my_project;";

        //parameterised constructor
        public ComputersMaintenanceForm(string data)
        {
            InitializeComponent();
            c_id_Txt.Text = data;
        }

        //Close the page
        private void computerClose_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Back button
        private void computerBack_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }

        //Show employee's computer info(method)
        public void showComputerInfo()
        {
            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                int computer_id = Convert.ToInt32(c_id_Txt.Text);
                string query = "select computer_id,hostname,brand,person_using," +
                    "DATE_FORMAT(maintenance_date, '%d-%m-%Y') AS maintenance_date ," +
                    "DATE_FORMAT(start_date, '%d-%m-%Y') AS start_date  " +
                    "from maintenanceview where computer_id=@computer_id";

                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@computer_id", computer_id);

                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            hostnameLbl.Text = "Hostname: " + reader["hostname"].ToString();
                            brandLbl.Text = "Markası: " + reader["brand"].ToString();
                            personUsingLbl.Text = "Kullanan Kişi: " + reader["person_using"].ToString();
                            start_date.Text = "Kullanmaya Baş. Tarih: " + reader["start_date"].ToString();
                            maintenanceDateLbl.Text = "PC Bakım Tarihi: " + reader["maintenance_date"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bilgileri bulunamadı.");
                        }

                        //Calculate the difference between the maintenance date and today's date
                        //Alert light is work?
                        DateTime maintenance = Convert.ToDateTime(reader["maintenance_date"]);
                        DateTime today = DateTime.Today;
                        TimeSpan difference = maintenance - today;

                        if (difference.TotalDays <= 5)
                        {
                            alert1.Visible = true;
                        }
                        else
                        {
                            alert1.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }

        }

        //Show employee's computer info
        private void ComputersMaintenanceForm_Load(object sender, EventArgs e)
        {
            showComputerInfo();
        }


        //After click button you can see next maintenance date and you completed maintenance
        private void apply_button_Click(object sender, EventArgs e)
        {
            int computer_id = Convert.ToInt32(c_id_Txt.Text);
            string Query = "UPDATE computer_maintenance SET " +
                "maintenance_date = next_maintenance, next_maintenance = DATE_ADD(next_maintenance, INTERVAL 6 MONTH) " +
                "WHERE computer_id = @computer_id;";

            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@computer_id", computer_id);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bakım başarıyla tamamlandı!");
                        }
                        else
                        {
                            MessageBox.Show("Bakım tamamlanamadı, lütfen tekrar deneyin.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

                string query = "select DATE_FORMAT(maintenance_date, '%d-%m-%Y') AS maintenance_date from computer_maintenance where computer_id=@computer_id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@computer_id", computer_id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        maintenanceDateLbl.Text = "PC Bakım Tarihi: " + reader["maintenance_date"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri bulunamadı.");
                    }
                }
            }


        }

        //Refresh the page
        private void refresh_button_Click(object sender, EventArgs e)
        {
            showComputerInfo();
        }
    }
}
