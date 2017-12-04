using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Projekt_3LJ_Hausverwaltung
{
    class Fachkonzept1 : IFachkonzept
    {
        IDatenhaltung datenhaltung;
        public Fachkonzept1(IDatenhaltung datenhaltung)
        {
            this.datenhaltung = datenhaltung;
        }
 #region TUI => Fachkonzept
        #region Anzeigemethoden
        public List<Hausbesitzer> HoleHausbesitzer()
        {
            List<Hausbesitzer> hausbesitzerliste = datenhaltung.HoleHausbesitzer();
            return hausbesitzerliste;
        }


        public List<Immobilie> HoleImmobillie()
        {
            List<Immobilie> immobilienliste = datenhaltung.HoleImmobilien();
            return immobilienliste;
        }

        public void HoleBesitzerverhaeltnis()
        {

        }

        #endregion

        #region anlagemethoden
        public void AnlageHausbesitzer()
        {

        }

        public void AnlageImmobilie()
        {

        }

        public void AnlageBesitzerverhaeltnis()
        {

        }

        #endregion

        #region aenderungsmethoden

        public void AendereHausbesitzer()
        {

        }

        public void AendereImmobiliendaten()
        {

        }

        public void AendereBesitzerverhaeltnis()
        {

        }

        #endregion

        #region loeschmethoden

        public void LoescheHausbesitzer()
        {

        }

        public void LoescheImmobiliendaten()
        {

        }

        public void LoescheBesitzerverhaeltnis()
        {

        }

        #endregion

        #region Endmethode
        public void ProgrammEnde()
        {
            Environment.Exit(0);
        }
        #endregion
        #endregion

        #region Fachkonzept => DB

        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=C:\Users\Krause\Documents\Hausverwaltungs_DB.mdf;
                Integrated Security=True;
                Connect Timeout=30");
        public static void DB_Connect()
        {
            
        }

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

#endregion

    }

}

