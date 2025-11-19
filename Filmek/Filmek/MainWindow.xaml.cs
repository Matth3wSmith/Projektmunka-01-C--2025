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

        private void FajlbaIras(List<Film> filmek,string fajlnev)
        {
            StreamWriter ir = new StreamWriter(fajlnev);
            ir.WriteLine(String.Join("\n",filmek.Select(x=>x.ToString())));
            ir.Close();
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
            List<string> cimSzavak = new List<string> { "Tenger", "Virág", "Hegy", "Fa", "Fény", "Szél", "Cseresznye", "Kávé", "Tükör", "Éjszaka", "Eső", "Tánc", "Tűz", "Málna", "Farkas", "Szikla", "Ló", "Csillag", "Híd", "Farkas", "Láng", "Múzeum", "Rózsa", "Zene", "Fagylalt", "Víz", "Madár", "Irány", "Hó", "Felhő", "Arany", "Csónak", "Sál", "Kép", "Láng", "Kikötő", "Ház", "Kert", "Lovas", "Vihar", "Pillangó", "Hal", "Film", "Színház", "Számítógép", "Olvasás", "Fodrász", "Öröm", "Táj", "Sütő", "Étterem", "Képzelet", "Kép", "Nyár", "Fáklya", "Esernyő", "Táska", "Papír", "Táj", "Természet", "Hópehely", "Művészet", "Légzés", "Zseblámpa", "Kamera", "Szem", "Árnyék", "Gondolat", "Barát", "Boldogság", "Friss", "Hold", "Varázslat", "Álom", "Kaland", "Erdő", "Út", "Tavasz", "Korona", "Képzelet", "Esőcsepp", "Határ", "Pillanat", "Telefon", "Nyelv", "Zsák", "Futás", "Képregény", "Láp", "Téli", "Kávézó", "Levegő", "Tej", "Mosoly", "Család", "Répa", "Képzés", "Homok", "Fényképezőgép", "Szemüveg", "Idő", "Tér", "Látás", "Tükörkép", "Könyv", "Lakás", "Fényforrás", "Hang", "Képesség", "Hűség", "Túlélés", "Piac", "Kávé", "Hóember", "Képzelet", "Napfény", "Róka", "Reggel", "Csillogás", "Állat", "Hóesés", "Távolság", "Közel", "Nevetés", "Vízesés", "Halom", "Csend", "Mozgás", "Cél", "Virágzás", "Táblázat", "Otthon", "Tükröződés", "Farkas", "Iskola", "Frissesség", "Hűvös", "Takaró", "Gázló", "Futó", "Folyó", "Szikla", "Úszás", "Bor", "Szomjúság", "Társaság", "Zöld", "Pihenés", "Növény", "Szivárvány", "Esőcsepp", "Lóhere", "Hófehérke", "Pásztor", "Hópehely", "Horgászat", "Madárfészek", "Kézműves", "Előadás", "Pálya", "Látogató", "Történet", "Naplemente", "Mese", "Házikó", "Sütőpor", "Erő", "Vízpart", "Faág", "Kémia", "Sajt", "Kávézó", "Napló", "Almás", "Pihenő", "Ág", "Patak", "Vitorlás", "Képesség", "Tábor", "Képzelet", "Téli", "Folyópart", "Törpe", "Változás", "Párna", "Rágó", "Takaró", "Hó", "Alvás", "Búza", "Kávézó", "Kuckó", "Árnyék", "Róka", "Kép", "Páfrány", "Rózsa", "Bútor", "Tükröződés" };

            List<string> vezeteknevek = new List<string> { "Smith", "Johnson", "Brown", "Taylor", "Williams", "Jones", "Davis", "Miller", "Wilson", "Moore", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "King", "Wright", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster", "Gonzalez", "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes", "Freeman", "Gordon", "Wallace", "Woods", "Chavez", "Morris", "Reynolds", "Schmidt", "Kim", "Bishop", "Shaw", "Craig", "Bryant", "Arnold", "Chavez", "Riley", "Hughes", "Foster", "Pierce", "Nichols", "Lloyd", "Hayward", "Cameron", "Russell", "Vaughn", "Warren", "Sullivan", "Curtis", "Mason", "Peters", "Graham", "Knight", "Hunt", "Gibson", "Lynch", "Craig", "Carlson", "Palmer", "Rogers", "Watkins", "Barnett", "Watts", "Chapman", "Meyer", "Dixon", "Henderson", "Fowler", "Richards", "Harrison", "Little", "Bryant", "Holmes", "Galloway", "Campbell", "Davidson", "Hale", "Madden", "Hancock", "Booth", "Douglas", "Wallace", "Bishop", "Jefferson", "Burns", "Woods", "Farrell", "Stewart", "Nelson", "Simmons", "Maddox", "Strickland", "McCoy", "Montgomery", "Ramsay", "Webb", "Hicks", "Elliott", "Sullivan", "Nicholson", "Scott", "Porter", "Craig", "Stanley", "Bennett", "Turner", "Holland", "Chapman" };

            List<string> keresztnevek = new List<string> { "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas", "Christopher", "Daniel", "Matthew", "Anthony", "Mark", "Donald", "George", "Paul", "Steven", "Andrew", "Kenneth", "Joshua", "Kevin", "Brian", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan", "Gary", "Nicholas", "Eric", "Stephen", "Larry", "Justin", "Scott", "Brandon", "Benjamin", "Samuel", "Gregory", "Frank", "Alexander", "Patrick", "Jack", "Dennis", "Jerry", "Tyler", "Aaron", "Henry", "Douglas", "Zachary", "Peter", "Ethan", "Walter", "Kyle", "Carl", "Arthur", "Ryan", "Roger", "Joe", "Christian", "Austin", "Jordan", "Evan", "Keith", "Carlos", "Terry", "Gerald", "Dylan", "Juan", "Jesse", "Willie", "Billy", "Bruce", "Adam", "Harry", "Alan", "Lawrence", "Nathan", "Franklin", "Raymond", "Roy", "Louis", "Bobby", "Harry", "Ralph", "Gabriel", "Wayne", "Randy", "Carlton", "Shawn", "Jackie", "Sam", "Derrick", "Glenn", "Victor", "Howard", "Johnny", "Russell", "Jordan", "Dennis", "Warren", "Marvin", "Curtis", "Morris", "Chad", "Leonard", "Arthur", "Leroy", "Clarence", "Vincent", "Keith", "Gilbert", "Leon", "Francis", "Norman", "Leo", "Oscar", "Barry", "Joel", "Benny", "Herman", "Nathaniel", "Lester", "Jackie", "Gene", "Milton", "Allan", "Ernest", "Calvin", "Lyle", "Ray", "Edwin", "Harold", "Pete", "Jim", "Terry", "Charlie", "Glenn", "Eugene", "Bob", "Dean", "Melvin", "Stanley", "Alvin", "Sidney", "Maurice", "Bert", "Claude", "Erik", "Louis", "Roderick", "Lenny", "Ivan", "Maurice", "Billy", "Marvin", "Dale", "Emmett", "Jared", "Ronnie", "Clifford", "Nash", "Kurt", "Gilbert", "Wilfred", "Milton", "Mickey", "Roland", "Felix", "Terry", "Kenny", "Reggie", "Royce", "Elmer", "Angelo", "Jules", "Clyde", "Monty", "Randall", "Ricky", "Eddie", "Quincy", "Stan", "Tommy" };

            List<string> mufajok = new List<string> { "Akció", "Kaland", "Animáció", "Képregény", "Bűnügyi", "Dokumentumfilm", "Dráma", "Romantikus", "Sci-fi", "Thriller", "Horror", "Komédia", "Művészfilm", "Történelmi", "Fantasy", "Zenei", "Western", "Szuperhős", "Sport", "War", "Tudományos", "Művészeti", "Musical", "Rejtély", "Krimi", "Kísértet", "Életrajzi", "Családi", "Felnőtt", "Szerelem", "Politikai", "Zsánerfilm", "Indie", "Csoportos", "Képregényfilm", "Romantikus vígjáték", "Pszichológiai thriller", "Tudományos fantasztikus", "Filozofikus", "Szatíra", "Paródia", "Túlélő", "Mindentudó", "Noir", "Gore", "Képregényadaptáció", "Drámai vígjáték", "Képregények", "Démoni", "Musical vígjáték", "Társadalmi dráma", "Felnőtt vígjáték", "Poszt-apokaliptikus", "Tudományos dráma", "Mítikus", "Születési történet", "Hóhér", "Hibás hős", "Képregényadaptáció", "Képregény vígjáték", "Gyilkosság", "Akció vígjáték", "Családi dráma", "Testvériség", "Zombis", "Romantikus dráma", "Kalandfilm", "Kreatív vígjáték", "Sötét humor", "Középiskolai dráma", "Kiborgos", "Posztmodern", "Alföldi", "Fekete komédia", "Történelmi dráma", "Börtönfilm", "Gyermekfilm", "Képregényes dráma", "Szépségverseny", "Modern városi", "Pszichodráma", "Búvárkodás", "Katona dráma", "Szerelem történet", "Film noir", "Túlvilági", "Képregényhősök", "Horror vígjáték", "Vámpíros", "Felfedezés", "Önvédelmi", "Játékfilm", "Képregényes akció", "Képregény adaptáció", "Kémfilm", "Birodalmi háborús", "Házastársi dráma", "Művészeti vígjáték", "Démoni dráma", "Képregényes vígjáték" };

            List<string> dijak = new List<string> { "Academy Award", "Golden Globe", "Cannes Film Festival Palme d'Or", "BAFTA Award", "Screen Actors Guild Award", "Venice Film Festival Golden Lion", "César Award", "Critics' Choice Movie Award", "Saturn Award", "Teen Choice Award", "MTV Movie & TV Award", "Primetime Emmy Award", "Independent Spirit Award", "Tony Award", "Golden Raspberry Award", "Critics' Choice Television Award", "People's Choice Award", "Hugo Award", "Annie Award", "Berlin International Film Festival Golden Bear" };

            List<string> gyartok = new List<string> { "Warner Bros.", "Universal Pictures", "Paramount Pictures", "20th Century Studios", "Columbia Pictures", "Sony Pictures", "Walt Disney Pictures", "Lionsgate Films", "New Line Cinema", "MGM Studios", "DreamWorks Pictures", "Metro-Goldwyn-Mayer", "Focus Features", "A24", "Pixar Animation Studios", "Legendary Entertainment", "Studio Ghibli", "Filmhansa", "Working Title Films", "Blue Sky Studios", "Lionsgate", "IFC Films", "Dimension Films", "Alliance Films", "TriStar Pictures", "Open Road Films", "EuropaCorp", "Screen Gems", "Cineworld", "Pathé", "Summit Entertainment", "TWC (The Weinstein Company)", "BBC Films", "Film4 Productions", "Koch Media", "Magnolia Pictures", "Walden Media", "Grindhouse Releasing", "Tartan Films", "Bleecker Street", "GKids", "Summit Entertainment", "Silver Pictures", "StudioCanal", "Newmarket Films", "Rogue Pictures", "Hammer Film Productions", "Eros International" };

            Random rnd = new Random();

            StreamWriter sr = new StreamWriter("filmek.txt");

            for (int j = 0; j < 200; j++)
            {
                string cim = "";
                for (int i = 0; i < 3; i++)
                {
                    cim += cimSzavak[rnd.Next(0, cimSzavak.Count)];
                    cim += " ";
                }
                cim = cim.Remove(cim.Length - 1, 1);


                List<string> mufajai = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    int sorsoltIndex = rnd.Next(0, mufajok.Count);
                    mufajai.Add(mufajok[sorsoltIndex]);
                    mufajok.RemoveAt(sorsoltIndex);
                }

                for (int i = 0; i < mufajai.Count; i++)
                {
                    mufajok.Add(mufajai[i]);
                }


                int hossz = rnd.Next(0, 400);


                string megjelenesDatum = "";

                int ev = rnd.Next(1940, 2026);
                string honap = "";
                int honapSzam = rnd.Next(1, 13);

                if (honapSzam < 10)
                {
                    honap = $"0{honapSzam}";
                }
                else
                {
                    honap = honapSzam.ToString();
                }

                string nap = "";
                int napSzam = rnd.Next(1, 31);
                if (napSzam < 10)
                {
                    nap = $"0{napSzam}";
                }
                else
                {
                    nap = napSzam.ToString();
                }


                string datum = $"{ev}.{honap}.{nap}.";


                Console.WriteLine(cim);



                for (int i = 0; i < mufajai.Count; i++)
                {
                    Console.WriteLine(mufajai[i]);
                }

                Console.WriteLine(datum);

                string szinesz = "";
                string szerep = "";

                List<string> szineszekesSzerepek = new List<string>();

                for (int i = 0; i < 5; i++)
                {
                    szinesz += vezeteknevek[rnd.Next(0, vezeteknevek.Count)] + " ";
                    szinesz += keresztnevek[rnd.Next(0, keresztnevek.Count)];

                    szerep += vezeteknevek[rnd.Next(0, vezeteknevek.Count)] + " ";
                    szerep += keresztnevek[rnd.Next(0, keresztnevek.Count)];

                    szineszekesSzerepek.Add($"{szinesz} - {szerep}");
                    szerep = "";
                    szinesz = "";

                }

                for (int i = 0; i < szineszekesSzerepek.Count; i++)
                {
                    Console.WriteLine(szineszekesSzerepek[i]);
                }

                List<string> elnyertdijak = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    int sorsoltIndex = rnd.Next(0, dijak.Count);
                    elnyertdijak.Add(dijak[sorsoltIndex]);
                    dijak.RemoveAt(sorsoltIndex);
                }

                for (int i = 0; i < elnyertdijak.Count; i++)
                {
                    dijak.Add(mufajai[i]);
                }

                string dijakBeir = elnyertdijak.ToString();
                Console.WriteLine(dijakBeir);
                for (int i = 0; i < elnyertdijak.Count; i++)
                {
                    Console.WriteLine(elnyertdijak[i]);
                }


                string rendezo = $"{vezeteknevek[rnd.Next(0, vezeteknevek.Count)]} {keresztnevek[rnd.Next(0, keresztnevek.Count)]}";

                Console.WriteLine(rendezo);

                string forgatokonyvIro = $"{vezeteknevek[rnd.Next(0, vezeteknevek.Count)]} {keresztnevek[rnd.Next(0, keresztnevek.Count)]}";

                Console.WriteLine(forgatokonyvIro);

                string zeneszerzo = $"{vezeteknevek[rnd.Next(0, vezeteknevek.Count)]} {keresztnevek[rnd.Next(0, keresztnevek.Count)]}";

                Console.WriteLine(zeneszerzo);

                string gyarto = gyartok[rnd.Next(0, gyartok.Count)];

                Console.WriteLine(gyarto);

                List<int> korhatarok = new List<int> { 6, 12, 16, 18 };

                int korhatar = korhatarok[rnd.Next(0, korhatarok.Count)];

                Console.WriteLine(korhatar);


                sr.WriteLine($"{cim};{string.Join(",", mufajai)};{hossz};{datum};{string.Join(",", szineszekesSzerepek)};{string.Join(",", elnyertdijak)};{rendezo};{forgatokonyvIro};{zeneszerzo};{gyarto};{korhatar}");

            }

            sr.Close();

        }
    }
}