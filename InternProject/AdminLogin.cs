using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using K4os.Compression.LZ4.Encoders;
using System.ComponentModel.Design;



namespace InternProject
{
    public partial class AdminLogin : Form
    {
        //MySQL connection adress
        string connAdress = "server=127.0.0.1;uid=root;port=3306;pwd=12345;database=my_project;";

        public AdminLogin()
        {
            InitializeComponent();
        }

        //Close the page
        private void adminClose_Label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Return previous page
        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //Admin password hide
        private void showPasswordAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordAdmin.Checked)
            {
                admin_password.PasswordChar = '\0';
            }
            else
            {
                admin_password.PasswordChar = '*';
            }
        }

        //Admin login button
        private void adminLogin_button_Click(object sender, EventArgs e)
        {

            string username = admin_username.Text.ToString();
            string password = admin_password.Text.ToString();

            string query = "select * from admins where username=@username and password=@password";

            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    if (adminComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Lütfen Seçim Yapınız!");
                    }
                    else
                    {
                        string selectedItem = adminComboBox.SelectedItem.ToString();
                        switch (selectedItem)
                        {
                            case "PC Bakımı":
                                IntermediateForm intermediate = new IntermediateForm();
                                intermediate.Show();
                                //this.Hide();
                                break;

                            case "Log":
                                LogForm logForm = new LogForm();
                                logForm.Show();
                                this.Close();
                                break;

                            case "Zimmet":
                                AgreementForm agreement = new AgreementForm();
                                agreement.Show();
                                this.Close();
                                break;
                        }
                    }

                }

                else { MessageBox.Show("Giriş Başarısız!"); }

            }

        }
    }
}
