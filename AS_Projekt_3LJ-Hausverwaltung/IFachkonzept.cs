using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Projekt_3LJ_Hausverwaltung
{
    interface IFachkonzept
    {
        #region Anzeigemethoden
        List<Hausbesitzer> HoleHausbesitzer();

        List<Immobilie> HoleImmobillie();


         void HoleBesitzerverhaeltnis();


        #endregion

        #region anlagemethoden
        void AnlageHausbesitzer();


        void AnlageImmobilie();


        void AnlageBesitzerverhaeltnis();

        #endregion

        #region aenderungsmethoden

        void AendereHausbesitzer();

        void AendereImmobiliendaten();

        void AendereBesitzerverhaeltnis();

        #endregion

        #region loeschmethoden

        void LoescheHausbesitzer();

        void LoescheImmobiliendaten();

        void LoescheBesitzerverhaeltnis();

        #endregion

        #region Endmethode
        void ProgrammEnde();
        #endregion

    }
}
