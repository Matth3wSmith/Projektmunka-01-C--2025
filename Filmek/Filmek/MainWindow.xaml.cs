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
            MessageBox.Show(String.Join(" ",Szereplok1.Text.Split("\n")));
            
        }
    }
}