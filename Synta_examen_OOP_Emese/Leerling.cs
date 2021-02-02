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

        public Rapport LeerlingRapport = new Rapport();



        // heeft een drukRapportAf() methode 

        public void AddRapport(Rapport lRapport)
        {
            LeerlingRapport = lRapport;
        }


  

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

        public void AddMijnPunten(Vak lVak, int lPunt)
        {
            LeerlingRapport.rapportDict[lVak] = lPunt;
            LeerlingRapport.ingevuld = true;
        }

        public void DrukMijnRapportAf()
        {


            Console.WriteLine($"\n\nStudent Naam: {Achternaam}, {Voornaam}");

            if (LeerlingRapport.ingevuld == false)
            {
                Console.WriteLine("Student heeft geen rapport");
            }

            else
            {
                LeerlingRapport.drukRapportAf();
            }
          
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
