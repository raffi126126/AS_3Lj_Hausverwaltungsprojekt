using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Projekt_3LJ_Hausverwaltung
{
    class DBVerwaltung : IDatenhaltung
    {
        public List<Hausbesitzer> HoleHausbesitzer()
        {
            List<Hausbesitzer> hausbesitzerliste = new List<Hausbesitzer>();
            return hausbesitzerliste;
        }

        public List<Immobilie> HoleImmobilien()
        {
            List<Immobilie> immobilienliste = new List<Immobilie>();
            return immobilienliste;
        }
    }
}
