using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace InternProject
{
    public partial class IntermediateForm : Form
    {
        //MySQL connection adress
        string connAdress = "server=127.0.0.1;uid=root;port=3306;pwd=12345;database=my_project;";
        public IntermediateForm()
        {
            InitializeComponent();
        }

        //Apply button
        private void apply_button_Click(object sender, EventArgs e)
        {
            string computer_id = pcIDTxt.Text;

            ComputersMaintenanceForm form = new ComputersMaintenanceForm(computer_id);

            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                try
                {
                    connection.Open();
                    string query = "select computer_id from computers where computer_id=@computer_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@computer_id", computer_id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                form.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Lütfen tekrar deneyin.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }

        }

        //Close the page
        private void intermediateClose_Lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
