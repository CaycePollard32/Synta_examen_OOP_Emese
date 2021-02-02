using System;
using System.Collections.Generic;
using System.Text;

namespace Synta_examen_OOP_Emese
{
    class Richting
    {

        private string naam;
        private string graad;
        Vak VakR { get; set; }


        public string Naam { get { return naam; } set { naam = value; } }
        public string Graad { get { return graad; } set { graad = value; } }

        public  List<Vak> VakLijstRichting = new List<Vak>();

        public  List<Leerling> LeerlingLijstRichting = new List<Leerling>();


        public void InschrijvingStudent(Leerling rLeerling)
        {
            LeerlingLijstRichting.Add(rLeerling);
        }

        public void AddVakken(Vak rVak)
        {
            VakLijstRichting.Add(rVak);
        }

        public Richting()
        {

        }



        public Richting(string aNaam, string aGraad)
        {
           Naam = Naam;
           Graad = aGraad;
  

        }

        public Richting(string bNaam)
        {
            Naam = bNaam;
        }

      
    }
}
