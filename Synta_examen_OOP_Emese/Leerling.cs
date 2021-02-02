using System;
using System.Collections.Generic;
using System.Text;

namespace Synta_examen_OOP_Emese
{
    class Leerling:Persoon
    {
        private string leerjaar;

        public string RichtingNaam;

        public string Leerjaar { get; set; }

        // heeft een richting object
        // heeft een rapport hierin worden punten bijgehouden van de vakken van de studierichting.


        // heeft een drukRapportAf() methode 

        public Leerling()
        {

        }

        public Leerling(string lVoornaam, string lAchternaam, int lLeeftijd, string lWoonplaats, string lGeslacht, string lLeerjaar, string lRichtingNaam)
        {
            Voornaam = lVoornaam;
            Achternaam = lAchternaam;
            Leeftijd = lLeeftijd;
            Woonplaats = lWoonplaats;
            Geslacht = lGeslacht;
            Leerjaar = lLeerjaar;
            RichtingNaam = lRichtingNaam;

        }

        public Leerling(string lVoornaam, string lAchternaam)
        {
            Voornaam = lVoornaam;
            Achternaam = lAchternaam;

        }

        public override void ToonVolledigNaam()
        {
            Console.WriteLine(Achternaam +", "+Voornaam);
        }
    }
}
