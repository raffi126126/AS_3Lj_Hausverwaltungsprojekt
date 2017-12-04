using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Projekt_3LJ_Hausverwaltung
{
    interface IDatenhaltung
    {
        List<Immobilie> HoleImmobilien();

        List<Hausbesitzer> HoleHausbesitzer();
    }
}
