using System;
using System.Collections.Generic;
using System.Text;

namespace Synta_examen_OOP_Emese
{
    class Rapport : Richting
    {
        private string id;

        public string ID { get { return id; } set { id = value; } }


        Dictionary<Vak, int> rapportDict = new Dictionary<Vak, int>();


        public void AddVakEnPunt(Vak rVak, int aPunt)
        {
            rapportDict.Add(rVak, aPunt);
        }


        public void drukRapportAf()
        {
            Console.WriteLine("Rapport ID: " + id);

            foreach (var item in rapportDict)
            {
                Console.WriteLine($"Vak: {item.Key.Naam}, Punt: {item.Value}, Percentage: {(100 * item.Value) / 20}%");
            }

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
