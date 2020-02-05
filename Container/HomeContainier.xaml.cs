using System;
using System.Collections.Generic;
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
    /// Interaction logic for HomeContainier.xaml
    /// </summary>
    public partial class HomeContainier : UserControl
    {

        List<PatientModel> patient = new List<PatientModel>();


        public HomeContainier()
        {
            InitializeComponent();
        }

        

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            PatientModel pm = new PatientModel();

            pm.Name = NameTxt.Text;
            pm.DateTime = DateTime.Now.ToString();
            pm.phone = int.Parse(phoneTxt.Text);
            pm.SHC = SHCTxt.Text;
            pm.treatment = treatmentTxt.Text;
            pm.VisitNumber = int.Parse(visitNumerTxt.Text);
            pm.weight = float.Parse(weightTxt.Text);
            pm.allergy = allergyTxt.Text;
            pm.Age = int.Parse(AgeTxt.Text);
            pm.add = addTxt.Text;
            pm.finding = findingTxt.Text;
            pm.DSW = dswTxt.Text;
            if (b_Male.IsChecked == true)
            {
                pm.Gender = "Male";
            }
            else pm.Gender = "Female";

            SqliteDataAccess.SavePatient(pm);



        }

    }
}
