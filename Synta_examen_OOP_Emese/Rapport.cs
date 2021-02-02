using System;
using System.Collections.Generic;
using System.Text;

namespace Synta_examen_OOP_Emese
{
    class Rapport : Richting
    {
        private string id;

        public string ID { get { return id; } set { id = value; } }


        Leerling leerlingR = new Leerling();

        Dictionary<Vak, int> rapportDict = new Dictionary<Vak, int>();


        public void AddVakEnPunt(Vak rVak, int aPunt)
        {
            rapportDict.Add(rVak, aPunt);
        }



        public Rapport()
        {

        }

        public Rapport(string aRichtingNaam, string aID)
        {
            Naam = aRichtingNaam;
            ID = aID;
        }


        public Rapport(string bID)
        {
            ID = bID;
        }
    }
}
