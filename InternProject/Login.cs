using MySql.Data.MySqlClient;
using System.Text;

namespace InternProject
{
    public partial class Login : Form
    {
        //MySQL connection
        string connAdress = "server=127.0.0.1;uid=root;port=3306;pwd=12345;database=my_project;";
        public Login()
        {
            InitializeComponent();
        }

        //Close the page
        private void loginCloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //If you click this label, you are going to admin panel
        private void adminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        //If you click this checkBox, you are going to see your password
        private void showPasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordLogin.Checked)
            {
                passwordTxt.PasswordChar = '\0';
            }
            else
            {
                passwordTxt.PasswordChar = '*';
            }
        }

        //Login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            //Check role at ComboBox
            if (roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("L�tfen rol se�iniz!");
                return;
            }

            string username = usernameTxt.Text.Trim().ToString();
            string password = passwordTxt.Text.ToString();
            string role = roleComboBox.SelectedItem.ToString();

            string query = "select username,password,role from users where " +
            "username=@username and password=@password and role=@role";

            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();


                try
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Giri� Ba�ar�l�");
                        string selectedItem = roleComboBox.SelectedItem.ToString();
                        switch (selectedItem)
                        {
                            case "Bak�mc�":
                                MaintenanceForm maintenance = new MaintenanceForm(username, password);
                                maintenance.Show();
                                this.Hide();
                                break;

                            case "Stok�u":
                                StockForm stockForm = new StockForm();
                                stockForm.Show();
                                this.Hide();
                                break;

                            case "Vardiya Amiri":
                                MaintenanceForm maintenance2 = new MaintenanceForm(username, password);
                                maintenance2.Show();
                                this.Hide();
                                break;
                        }

                    }

                    else { MessageBox.Show("Giri� Ba�ar�s�z!"); }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritaban� ba�lant�s�nda bir hata olu�tu: " + ex.Message);
                }

            }


        }


    }
}


