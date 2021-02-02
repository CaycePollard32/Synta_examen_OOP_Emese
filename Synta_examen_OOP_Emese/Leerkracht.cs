using System;
using System.Collections.Generic;
using System.Text;

namespace Synta_examen_OOP_Emese
{
    class Leerkracht : Persoon
    {
        private double loon;

        public double Loon { get { return loon; } set { loon = value; } }

        public static List<Vak> MijnVakken = new List<Vak>();
        //er moet een controle komen van de leerkracht object voordat de vakken kunnen toegevoegd woorden aan deze lijst

        public Leerkracht() { }

        
        public Leerkracht(string lVoornaam, string lAchternaam, int lLeeftijd, string lWoonplaats, string lGeslacht, double lLoon)
        {
            Voornaam = lVoornaam;
            Achternaam = lAchternaam;
            Leeftijd = lLeeftijd;
            Woonplaats = lWoonplaats;
            Geslacht = lGeslacht;
            Loon = lLoon;
        }

        public Leerkracht(double bLoon)
        {
            Loon = bLoon;
        }


        public void AddMijnVakken(Vak rVak)
        {
           MijnVakken.Add(rVak);
        }


        public override void ToonVolledigNaam()
        {
            throw new NotImplementedException();
        }
    }
}
