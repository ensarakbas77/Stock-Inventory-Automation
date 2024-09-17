using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace InternProject
{
    public partial class AgreementForm : Form
    {
        //MySQL connection adress
        string connAdress = "server=127.0.0.1;uid=root;port=3306;pwd=12345;database=my_project;";
        public AgreementForm()
        {
            InitializeComponent();
        }

        //Save employee info
        private void save_button_Click(object sender, EventArgs e)
        {
            string first_name = first_name_TXT.Text;
            string last_name = last_name_TXT.Text;
            string department = department_TXT.Text;

            using (MySqlConnection connection = new MySqlConnection(connAdress))
            {
                connection.Open();
                string query = "insert into employee(first_name,last_name,department) values (@first_name,@last_name,@department) ";
                string checkEmployeeQuery = "SELECT COUNT(*) FROM employee WHERE first_name=@first_name and " +
                    "last_name=@last_name and department=@department";
                using (MySqlCommand cmd = new MySqlCommand(checkEmployeeQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@first_name", first_name);
                    cmd.Parameters.AddWithValue("@last_name", last_name);
                    cmd.Parameters.AddWithValue("@department", department);

                    int employeeExists = Convert.ToInt32(cmd.ExecuteScalar());
                    if (employeeExists > 0)
                    {
                        MessageBox.Show("Bu çalışan zaten kayıtlı.");
                    }
                    else
                    {
                        try
                        {

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@first_name", first_name);
                                command.Parameters.AddWithValue("@last_name", last_name);
                                command.Parameters.AddWithValue("@department", department);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Ekleme İşlemi Başarılı");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }

            //Folder path 'Zimmet Formları Folder'
            string basePath = @"C:\Users\Ensar\OneDrive\Masaüstü\Zimmet Formları";
            //Open the folder 
            Process.Start("explorer.exe", basePath);

            //Create a folder for employee
            string userFolderPath = Path.Combine(basePath, first_name + " " + last_name);

            if (!Directory.Exists(userFolderPath))
            {
                MessageBox.Show("Klasör başarıyla oluşturuldu!");
                Directory.CreateDirectory(userFolderPath);
            }
            else
            {
                MessageBox.Show("Bu klasör zaten mevcut.");
            }

            //Copy word into the folder 'Bilgisayar Zimmet Formu'
            string wordPath = @"C:\Users\Ensar\OneDrive\Masaüstü\Zimmet Formu.docx";
            string destinationFilePath = Path.Combine(userFolderPath, Path.GetFileName(wordPath));

            try
            {

                if (!File.Exists(destinationFilePath))
                {
                    MessageBox.Show("Word dosyası başarıyla kopyalandı.");
                    File.Copy(wordPath, destinationFilePath);
                }
                else
                {
                    MessageBox.Show("Dosya zaten mevcut.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya kopyalama sırasında bir hata oluştu: {ex.Message}");
            }

            //Clear the textbox
            first_name_TXT.Clear();
            last_name_TXT.Clear();
            department_TXT.Clear();
        }

        //Back the previous page
        private void back_Lbl_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }

        //Exit the page
        private void exit_Lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Go to folder 'Zimmet Formları'
        private void link_LBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string basePath = @"C:\Users\Ensar\OneDrive\Masaüstü\Zimmet Formları";
            Process.Start("explorer.exe", basePath);
        }
    }
}
