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
        public string Cime { get; set; }
        public string Mufaja { get; set; }

        public int Hossza { get; set; }
        public DateOnly Datuma { get; set; }
        public string Szereploi { get; set; }
        public string Dijai { get; set; }
        public string Rendezoi { get; set; }
        public string forgatoKonyv { get; set; }
        public string Zenei {  get; set; }
        public string Gyartoja { get; set; }
        public int Korhatara {  get; set; }

       

    }
}
