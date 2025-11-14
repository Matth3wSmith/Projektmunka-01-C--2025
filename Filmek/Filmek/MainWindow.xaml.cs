using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Filmek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string cim;
        List<string> mufaj = new List<string>();
        int hossz;
        DateOnly datum;
        List<string> szereplok = new List<string>();
        List<string> dijak = new List<string>();
        string rendezo;
        string zene;
        string Gyarto;
        string forgatoKonvIro;
        int korhatar;



        private void Bekuldes_Click(object sender, RoutedEventArgs e)
        {
            cim = Cim.Text;
            Cim.Text = "";
            hossz = int.Parse(Hossz.Text);
            datum = DateOnly.FromDateTime(Datum.SelectedDate.Value.Date);
            MessageBox.Show(Szereplok1.Text);
            MessageBox.Show(String.Join(" ", Szereplok1.Text.Split("\n")));
        }


        private List<Film> Beolvasas(string fajl)
        {
            //"Cim;Műfaj;Hossz;Datum;Szereplok;Dijak;Rendezo;Forgatokonyv;Zene;Gyarto;Korhatar"
            //"Gyilkos gumiabroncs;horrofilm;102;2025.10.10;Nagaszaki Kimura-Abdul Kertik;Grammy-díj;Stanley Kubrick;Stanley Korrick;Zene és Tánc;Paramount;12"
            StreamReader olvas = new StreamReader(fajl);
            List<Film> filmek = new List<Film>();

            while (!olvas.EndOfStream)
            {
                string[] vag = olvas.ReadLine().Split(';');
                string[] datumvag = vag[3].Split('.');
                DateOnly datum = new DateOnly(int.Parse(datumvag[0]), int.Parse(datumvag[1]), int.Parse(datumvag[2]));

                filmek.Add(new Film(vag[0], vag[1].Split(",").ToList(), int.Parse(vag[2]), datum, vag[4].Split(",").ToList(), vag[5].Split(",").ToList(), vag[6], vag[7], vag[8], vag[9], int.Parse(vag[10])));

            }
            return filmek;
            olvas.Close();
        }

        private void DummyAdatok()
        {

        }
    }
}