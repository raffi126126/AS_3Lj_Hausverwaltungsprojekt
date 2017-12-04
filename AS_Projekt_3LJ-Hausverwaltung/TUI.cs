using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Projekt_3LJ_Hausverwaltung
{
    class TUI
    {
        IFachkonzept konzept;
        static string besitzerName;
        static string besitzerVorname;
        public TUI(IFachkonzept konzept)
        {
            this.konzept = konzept;
        }

        public void Startmenu()
        {
            #region TUI - User Interface
            Console.WriteLine("WSDB Hausverwaltungssoftware v1");
            Console.WriteLine();
            Console.WriteLine("######################################");
            Console.Write("# \t   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("<<< ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Hauptmenü ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(">>>");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t     #");
            Console.WriteLine("#------------------------------------#");
            Console.WriteLine("# Hausdaten Anzeigen \t\t (a) #");
            Console.WriteLine("# Haus anlegen \t\t\t (b) #");
            Console.WriteLine("# Haus ändern \t\t\t (c) #");
            Console.WriteLine("# Haus löschen \t\t\t (d) #");
            Console.WriteLine("#------------------------------------#");
            Console.WriteLine("# Hausbesitzerdaten anzeigen \t (e) #");
            Console.WriteLine("# Hausbesitzer anlegen \t\t (f) #");
            Console.WriteLine("# Hausbesitzer ändern \t\t (g) #");
            Console.WriteLine("# Hausbesitzer löschen \t\t (h) #");
            Console.WriteLine("#------------------------------------#");
            Console.WriteLine("# Besitzerverhältnisse anzeigen\t (i) #");
            Console.WriteLine("# Neues Besitzerverhältnis \t (j) #");
            Console.WriteLine("# Besitzerverhältnis ändern \t (k) #");
            Console.WriteLine("# Besitzerverhältnis löschen \t (l) #");
            Console.WriteLine("#------------------------------------#");
            Console.WriteLine("# Ende \t\t\t\t (q) #");
            Console.WriteLine("######################################");
            #endregion
        }
        public static void TUIEingabe()
        {
            try
            {
                Program.benutzereingabe = Convert.ToChar(Console.ReadLine().ToLower());
            }
            catch
            {
                Console.WriteLine("hi");

            }

            switch (Program.benutzereingabe)
            {
                case 'a':
                    {
                        //ZeigeHausbesitzer();
                        Console.ReadKey();
                        break;
                    }

                case 'b':
                    {

                        break;
                    }

                case 'c':
                    {

                        break;
                    }

                case 'd':
                    {

                        break;
                    }

                case 'e':
                    {

                        break;
                    }

                case 'f':
                    {
                        ///AnlageHausbesitzer();
                        break;
                    }

                case 'g':
                    {

                        break;
                    }

                case 'h':
                    {

                        break;
                    }

                case 'i':
                    {

                        break;
                    }

                case 'j':
                    {

                        break;
                    }

                case 'k':
                    {

                        break;
                    }

                case 'l':
                    {

                        break;
                    }

                case 'q':
                    {
                        //Fachkonzept1.ProgrammEnde();
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        public static void TUIBesitzerAnlage()
        {
            Console.WriteLine("WSDB Hausverwaltungssoftware v1");
            Console.WriteLine();
            Console.WriteLine("######################################");
            Console.Write("# \t   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("<<< ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Besitzeranlage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(">>>");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t     #");
            Console.WriteLine("#------------------------------------#");
            Console.WriteLine("Bitte den Namen des neuen Besitzers angeben: ");
            Console.Write("Name: ");
            besitzerName = Console.ReadLine();
            Console.WriteLine("Bitte den Vornamamen des neuen Besitzers angeben: ");
            Console.Write("Name: ");
            besitzerVorname = Console.ReadLine();
            Console.WriteLine("# Ende \t\t\t\t (q) #");
            Console.WriteLine("OK");
            Console.ReadKey();
            Console.WriteLine("######################################");
           // DatenBankbefehl("test");
        }

        private void ZeigeHausbesitzer()
        {
            List<Hausbesitzer> hblist = konzept.HoleHausbesitzer();

            foreach (Hausbesitzer h in hblist)
                // Console.WriteLine(h.name);
                ;
        }

        private void ZeigeImmobilier()
        {
            List<Immobilie> immolist = konzept.HoleImmobillie();

            foreach (Immobilie i in immolist)
                //Console.WriteLine(h.name);
                ;
        }
        /*
        private void ZeigeBesitzerverhaeltnis()
        {
            List<Hausbesitzer> hblist = konzept.HoleHausbesitzer();

            foreach (Hausbesitzer h in hblist)
                //Console.WriteLine(h.name);
        }
        */
    }
}
