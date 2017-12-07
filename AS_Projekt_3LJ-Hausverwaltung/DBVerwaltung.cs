using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AS_Projekt_3LJ_Hausverwaltung
{

    class DBVerwaltung : IDatenhaltung
    {

        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=C:\Users\Krause\Documents\Hausverwaltungs_DB.mdf;
                Integrated Security=True;
                Connect Timeout=30");

        public static void DatenBankbefehl(string sqlBefehl)
        {

            //SqlConnection Con = new SqlConnection(sqlCon);
            var commandStr = "If not exists (select name from sysobjects where name = 'Customer') CREATE TABLE Customer(First_Name char(50),Last_Name char(50),Address char(50),City char(50),Country char(25),Birth_Date datetime)";

            using (SqlCommand command = new SqlCommand(commandStr, con))
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                }

        }

        public List<Hausbesitzer> HoleHausbesitzer()
        {
            List<Hausbesitzer> hausbesitzerliste = new List<Hausbesitzer>();

            var commandStr = "If not exists (select name from sysobjects where name = 'Customer') CREATE TABLE Customer(First_Name char(50),Last_Name char(50),Address char(50),City char(50),Country char(25),Birth_Date datetime)";

            using (SqlCommand command = new SqlCommand(commandStr, con))
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                }

            return hausbesitzerliste;
        }

        public List<Immobilie> HoleImmobilien()
        {
            List<Immobilie> immobilienliste = new List<Immobilie>();
            return immobilienliste;
        }

        public List<Hausbesitzer> HoleBesitzerverhaeltnisse()
        {
            List<Hausbesitzer> haubesitzerverhaeltnisse = new List<Hausbesitzer>();
            return haubesitzerverhaeltnisse;
        }
    }
}
