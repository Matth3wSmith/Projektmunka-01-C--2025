using System.Xml.Schema;

namespace Fajlfeldolgozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //"Cim;Műfaj;Hossz;Datum;Szereplok;Dijak;Rendezo;Forgatokonyv;Zene;Gyarto;Korhatar"
            //"Gyilkos gumiabroncs;horrofilm;102;2025.10.10;Nagaszaki Kimura-Abdul Kertik;Grammy-díj;Stanley Kubrick;Stanley Korrick;Zene és Tánc;Paramount;12"
            StreamReader olvas = new StreamReader("filmek.csv");
            List<Film> filmek = new List<Film>();   

            while (!olvas.EndOfStream)
            {
                string[] vag = olvas.ReadLine().Split(';');
                string[] datumvag = vag[3].Split('.');
                DateOnly datum = new DateOnly(int.Parse(datumvag[0]), int.Parse(datumvag[1]), int.Parse(datumvag[2]));

                filmek.Add(new Film( vag[0], vag[1].Split(",").ToList() , int.Parse(vag[2]), datum, vag[4].Split(",").ToList(), vag[5].Split(",").ToList(), vag[6], vag[7], vag[8], vag[9], int.Parse(vag[10]) )  );

            }

            olvas.Close();



        }
    }
}
