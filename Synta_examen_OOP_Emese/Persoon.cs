using System;
using System.Collections.Generic;
using System.Text;

namespace Synta_examen_OOP_Emese
{
    abstract class Persoon // hier maak ik een abstracte klasse Persoon aan zodat de klasses Student, Leerkracht, Studentenbegeleider de onderstaande velden en methoders kunnen overerven. Hier maak ik geen constructor aan aangezien van een abstracte klasse geen objecten kunnen aangemaakt worden.
    {
        private string voornaam;
        private string achternaam;
        private int leeftijd;
        private string woonplaats;
        private string geslacht;

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public int Leeftijd { get; set; }
        public string Woonplaats { get; set; }

        public string Geslacht { get; set; }

        public abstract void ToonVolledigNaam();
      

    }
}
