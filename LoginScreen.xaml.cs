using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //SqlConnection sqlCon = new SqlConnection()
            //ConnectionStringSettings c = ConfigurationManager.ConnectionStrings["Default"];



            SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\ClinicDB.db;Version=3");

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                String query = "SELECT COUNT(1) FROM user WHERE name=@name AND password=@password";
                SQLiteCommand sqliteCommand = new SQLiteCommand(query, conn);
                sqliteCommand.CommandType = System.Data.CommandType.Text;
                sqliteCommand.Parameters.AddWithValue("@name", txtUsername.Text);
                sqliteCommand.Parameters.AddWithValue("@password", txtPassword.Password);
                int count = Convert.ToInt32(sqliteCommand.ExecuteScalar());

                conn.Close();
                if (count >= 1)
                {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No such user");
                }
            }
            catch
            {
                MessageBox.Show("An error has occured");
            }
        }

    }
    
}
