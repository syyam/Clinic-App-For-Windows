using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Controller
{
    class SqliteDataAccess
    {
        public static List<PatientModel> LoadPatient(PatientModel patient)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<PatientModel>("select * from Patient", patient);
                return output.ToList();
            }


        }

        public static void SavePatient(PatientModel patient)
        {

            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                Console.WriteLine(patient.Name.ToString());
                conn.Execute("insert into Patient (VisitNumber, DateTime, Name,DSW,Age,Gender,Weight,Phone,Add_,Allergy,SymHCon,Treatment,Finding) values (@VisitNumber, @DateTime, @Name, @DSW, @Age, @Gender, @weight, @phone, @add, @allergy, @SHC, @treatment, @finding)", patient);
            
            }

           
            Console.WriteLine("row inserted");
        }


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
