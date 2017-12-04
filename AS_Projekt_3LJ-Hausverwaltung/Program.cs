using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Projekt_3LJ_Hausverwaltung
{
    class Program
    {
        public static char benutzereingabe;

        static void Main(string[] args)
        {
            //Benutze Fachkonzept1
            
            TUI TextUserinterface = new TUI(new Fachkonzept1(new DBVerwaltung()));
            TUI.TUIEingabe();
            
        }
    }
}
