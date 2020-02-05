using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Controller;
using WpfApp1.Model;

namespace WpfApp1.Container
{
    /// <summary>
    /// Interaction logic for ViewDataContainer.xaml
    /// </summary>
    public partial class ViewDataContainer : UserControl
    {
        List<PatientModel> patient = new List<PatientModel>();

        public ViewDataContainer()
        {
            InitializeComponent();
            LoadPatientList();



        }

        private void LoadPatientList()
        {
            //PatientModel pm = new PatientModel();

            //patient = SqliteDataAccess.LoadPatient(pm);

            SQLiteConnection con = new SQLiteConnection(@"Data Source=.\ClinicDB.db;Version=3");
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select * from Patient", con);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable("Patient");
            sda.Fill(dt);
            mDataGrid.ItemsSource = dt.DefaultView;
            sda.Update(dt);

            con.Close();



        }
    }
}
