using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    internal class Film
    {
        //Cim;Műfaj;Hossz;Datum;Szereplok;Dijak;Rendezo;Forgatokonyv;Zene;Gyarto;Korhatar
        public string Cim { get; set; }
        public string Mufaj { get; set; }

        public int Hossz { get; set; }
        public DateOnly Datum { get; set; }
        public string Szereplok { get; set; }
        public string Dijak { get; set; }
        public string Rendezo { get; set; }
        public string forgatoKonyv { get; set; }
        public string Zene {  get; set; }
        public string Gyarto { get; set; }
        public int Korhatar {  get; set; }

       

    }
}
