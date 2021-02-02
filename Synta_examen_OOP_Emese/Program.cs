﻿using System;

namespace Synta_examen_OOP_Emese
{
    class Program
    {
        static void Main(string[] args)
        {

            //aanmaak Leerling objecten

            Leerling leerling1 = new Leerling { Achternaam = "Doc", Voornaam = "Jan", Leeftijd= 15, Woonplaats="Mechelen", Geslacht ="man", Leerjaar="vierde", RichtingNaam="ASO - Economie-Moderne talen" };
            Leerling leerling2 = new Leerling { Achternaam = "Stoetel", Voornaam = "Jan", Leeftijd = 15, Woonplaats = "Mechelen", Geslacht = "man", Leerjaar = "vierde", RichtingNaam = "ASO - Economie-Wetenschappen" };
            Leerling leerling3 = new Leerling { Achternaam = "Bloosje", Voornaam = "Lieve", Leeftijd = 16, Woonplaats = "Mechelen", Geslacht = "man", Leerjaar = "vijfde", RichtingNaam = "ASO - Economie-Wiskunde" };
            Leerling leerling4 = new Leerling { Achternaam = "Grumpie", Voornaam = "Charlotte", Leeftijd = 17, Woonplaats = "Mechelen", Geslacht = "vrouw", Leerjaar = "zesde", RichtingNaam = "ASO - Economie-Wiskunde" };
            Leerling leerling5 = new Leerling { Achternaam = "Niezel", Voornaam = "Pim", Leeftijd = 15, Woonplaats = "Mechelen", Geslacht = "man", Leerjaar = "vierde", RichtingNaam = "ASO - Economie-Wetenschappen" };
            Leerling leerling6 = new Leerling { Achternaam = "Dommel", Voornaam = "Tom", Leeftijd = 15, Woonplaats = "Mechelen", Geslacht = "man", Leerjaar = "vierde", RichtingNaam = "ASO - Economie-Wetenschappen" };
            Leerling leerling7 = new Leerling { Achternaam = "Giechel", Voornaam = "Sara", Leeftijd = 15, Woonplaats = "Mechelen", Geslacht = "vrouw", Leerjaar = "vierde", RichtingNaam = "ASO - Economie-Wetenschappen" };


            //aanmaak Vak objecten

            Vak vak1 = new Vak { Naam = "Wiskunde", Graad = "vierde", Leerplan="BOBIO4W" };
            Vak vak2 = new Vak { Naam = "Wiskunde", Graad = "vijfde", Leerplan = "BOBIO5W" };
            Vak vak3 = new Vak { Naam = "Wiskunde", Graad = "zesde", Leerplan = "BOBIO6W" };
            Vak vak4 = new Vak { Naam = "Economie", Graad = "vierde", Leerplan = "BOBIO4E" };
            Vak vak5 = new Vak { Naam = "Economie", Graad = "vijfde", Leerplan = "BOBIO5E" };
            Vak vak6 = new Vak { Naam = "Economie", Graad = "zesde", Leerplan = "BOBIO6E" };
            Vak vak7 = new Vak { Naam = "Wetenschappen", Graad = "zesde", Leerplan = "BOBIO6P" };

            //aanmaak Leerkracht objecten

            Leerkracht leerkracht1 = new Leerkracht { Achternaam = "Lakhiani", Voornaam = "Vishen", Geslacht="man", Leeftijd=42, Loon=3000, Woonplaats="Mechelen" };
            Leerkracht leerkracht2 = new Leerkracht { Achternaam = "Kwik", Voornaam = "Jim", Geslacht = "man", Leeftijd = 42, Loon = 3000, Woonplaats = "Mechelen" };
            Leerkracht leerkracht3 = new Leerkracht { Achternaam = "Byron", Voornaam = "Katie", Geslacht = "vrouw", Leeftijd = 42, Loon = 5000, Woonplaats = "Mechelen" };
            Leerkracht leerkracht4 = new Leerkracht { Achternaam = "Angelou", Voornaam = "Maya", Geslacht = "vrouw", Leeftijd = 78, Loon = 3000, Woonplaats = "Mechelen" };

            //aanmaak Studentenbegeleiders
            StudentenBegeleider studentenbegeleider1 = new StudentenBegeleider { Achternaam = "Branson", Voornaam = "Richard", Geslacht = "man", Leeftijd = 66, Woonplaats = "Mechelen" };
            StudentenBegeleider studentenbegeleider2 = new StudentenBegeleider { Achternaam = "Tolle", Voornaam = "Echart", Geslacht = "man", Leeftijd = 62, Woonplaats = "Mechelen" };
            StudentenBegeleider studentenbegeleider3 = new StudentenBegeleider { Achternaam = "Jung", Voornaam = "Karl", Geslacht = "man", Leeftijd = 42, Woonplaats = "Mechelen" };


            //aanmaak Richtingen objecten

            Richting richting1 = new Richting { Naam = "ASO - Economie-Moderne talen", Graad = "tweede" };

            Richting richting2 = new Richting { Naam = "ASO - Economie-Wiskunde", Graad = "derde" };

            Richting richting3 = new Richting { Naam = "ASO - Economie-Wetenschappen", Graad = "tweede" };


            //aanmaak Rapport objecten

            Rapport rapport2 = new Rapport { ID = "ABC02", Naam = "Rapport voor de tweede graad", Graad="derde" };

            Rapport rapport3 = new Rapport { ID = "ABC03", Naam = "Rapport voor de derde graad", Graad = "derde" };




        }
    }
}
