using System;
using System.Collections.Generic;
using System.Text;

namespace Synta_examen_OOP_Emese
{
    class Vak:Richting
    { 


        private string leerplan;
 
        public string Leerplan { get { return leerplan; } set { leerplan = value; } }
   

        public static Leerkracht Leraar = new Leerkracht();

        public Vak()
        {

        }

        public void AddLeerkracht(Leerkracht l)
        {
            Leraar = l;
        }


        public Vak(string aVakNaam, string aVakGraad, string aLeerplan)
        {
            base.Naam = aVakNaam;
            base.Graad = aVakGraad;
            Leerplan = aLeerplan;
        }

        public Vak(string bVakNaam, string bVakGraad)
        {
            base.Naam = bVakNaam;
            base.Graad = bVakGraad;
        }
    }
}
