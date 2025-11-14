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
        List<string> szereplok= new List<string>();
        List<string> dijak= new List<string>();
        string rendezo;
        string zene;
        string gyarto;
        string forgatoKonvIro;
        int korhatar;



        private void Bekuldes_Click(object sender, RoutedEventArgs e)
        {
            cim = Cim.Text;
            Cim.Text = "";
            hossz = int.Parse(Hossz.Text);
            datum = DateOnly.FromDateTime(Datum.SelectedDate.Value.Date);
            MessageBox.Show(Szereplok.Text);
            MessageBox.Show(String.Join(" ",Szereplok.Text.Split("\n")));

            string[] szereplo = Szereplok.Text.Split(";");
            szereplok = szereplo.ToList();
            
            string[] dij = Dijak.Text.Split(";");
            dijak = dij.ToList();

            //dijak.Select(e => MessageBox.Show(e));



            rendezo = Rendezo.Text;
            zene = Zene.Text;
            gyarto = Gyarto.Text;
            forgatoKonvIro = forgatoKonyv.Text;
            korhatar = Convert.ToInt32(Korhatar.Text);

        }
    }
}