namespace Dummyadatok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List <string> cimSzavak = new List<string>{ "Tenger", "Virág", "Hegy", "Fa", "Fény", "Szél", "Cseresznye", "Kávé", "Tükör", "Éjszaka", "Eső", "Tánc", "Tűz", "Málna", "Farkas", "Szikla", "Ló", "Csillag", "Híd", "Farkas", "Láng", "Múzeum", "Rózsa", "Zene", "Fagylalt", "Víz", "Madár", "Irány", "Hó", "Felhő", "Arany", "Csónak", "Sál", "Kép", "Láng", "Kikötő", "Ház", "Kert", "Lovas", "Vihar", "Pillangó", "Hal", "Film", "Színház", "Számítógép", "Olvasás", "Fodrász", "Öröm", "Táj", "Sütő", "Étterem", "Képzelet", "Kép", "Nyár", "Fáklya", "Esernyő", "Táska", "Papír", "Táj", "Természet", "Hópehely", "Művészet", "Légzés", "Zseblámpa", "Kamera", "Szem", "Árnyék", "Gondolat", "Barát", "Boldogság", "Friss", "Hold", "Varázslat", "Álom", "Kaland", "Erdő", "Út", "Tavasz", "Korona", "Képzelet", "Esőcsepp", "Határ", "Pillanat", "Telefon", "Nyelv", "Zsák", "Futás", "Képregény", "Láp", "Téli", "Kávézó", "Levegő", "Tej", "Mosoly", "Család", "Répa", "Képzés", "Homok", "Fényképezőgép", "Szemüveg", "Idő", "Tér", "Látás", "Tükörkép", "Könyv", "Lakás", "Fényforrás", "Hang", "Képesség", "Hűség", "Túlélés", "Piac", "Kávé", "Hóember", "Képzelet", "Napfény", "Róka", "Reggel", "Csillogás", "Állat", "Hóesés", "Távolság", "Közel", "Nevetés", "Vízesés", "Halom", "Csend", "Mozgás", "Cél", "Virágzás", "Táblázat", "Otthon", "Tükröződés", "Farkas", "Iskola", "Frissesség", "Hűvös", "Takaró", "Gázló", "Futó", "Folyó", "Szikla", "Úszás", "Bor", "Szomjúság", "Társaság", "Zöld", "Pihenés", "Növény", "Szivárvány", "Esőcsepp", "Lóhere", "Hófehérke", "Pásztor", "Hópehely", "Horgászat", "Madárfészek", "Kézműves", "Előadás", "Pálya", "Látogató", "Történet", "Naplemente", "Mese", "Házikó", "Sütőpor", "Erő", "Vízpart", "Faág", "Kémia", "Sajt", "Kávézó", "Napló", "Almás", "Pihenő", "Ág", "Patak", "Vitorlás", "Képesség", "Tábor", "Képzelet", "Téli", "Folyópart", "Törpe", "Változás", "Párna", "Rágó", "Takaró", "Hó", "Alvás", "Búza", "Kávézó", "Kuckó", "Árnyék", "Róka", "Kép", "Páfrány", "Rózsa", "Bútor", "Tükröződés" };

			List <string> vezeteknevek = new List<string>{ "Smith", "Johnson", "Brown", "Taylor", "Williams", "Jones", "Davis", "Miller", "Wilson", "Moore", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "King", "Wright", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster", "Gonzalez", "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes", "Freeman", "Gordon", "Wallace", "Woods", "Chavez", "Morris", "Reynolds", "Schmidt", "Kim", "Bishop", "Shaw", "Craig", "Bryant", "Arnold", "Chavez", "Riley", "Hughes", "Foster", "Pierce", "Nichols", "Lloyd", "Hayward", "Cameron", "Russell", "Vaughn", "Warren", "Sullivan", "Curtis", "Mason", "Peters", "Graham", "Knight", "Hunt", "Gibson", "Lynch", "Craig", "Carlson", "Palmer", "Rogers", "Watkins", "Barnett", "Watts", "Chapman", "Meyer", "Dixon", "Henderson", "Fowler", "Richards", "Harrison", "Little", "Bryant", "Holmes", "Galloway", "Campbell", "Davidson", "Hale", "Madden", "Hancock", "Booth", "Douglas", "Wallace", "Bishop", "Jefferson", "Burns", "Woods", "Farrell", "Stewart", "Nelson", "Simmons", "Maddox", "Strickland", "McCoy", "Montgomery", "Ramsay", "Webb", "Hicks", "Elliott", "Sullivan", "Nicholson", "Scott", "Porter", "Craig", "Stanley", "Bennett", "Turner", "Holland", "Chapman" };

			List <string> keresztnevek = new List<string>{ "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas", "Christopher", "Daniel", "Matthew", "Anthony", "Mark", "Donald", "George", "Paul", "Steven", "Andrew", "Kenneth", "Joshua", "Kevin", "Brian", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan", "Gary", "Nicholas", "Eric", "Stephen", "Larry", "Justin", "Scott", "Brandon", "Benjamin", "Samuel", "Gregory", "Frank", "Alexander", "Patrick", "Jack", "Dennis", "Jerry", "Tyler", "Aaron", "Henry", "Douglas", "Zachary", "Peter", "Ethan", "Walter", "Kyle", "Carl", "Arthur", "Ryan", "Roger", "Joe", "Christian", "Austin", "Jordan", "Evan", "Keith", "Carlos", "Terry", "Gerald", "Dylan", "Juan", "Jesse", "Willie", "Billy", "Bruce", "Adam", "Harry", "Alan", "Lawrence", "Nathan", "Franklin", "Raymond", "Roy", "Louis", "Bobby", "Harry", "Ralph", "Gabriel", "Wayne", "Randy", "Carlton", "Shawn", "Jackie", "Sam", "Derrick", "Glenn", "Victor", "Howard", "Johnny", "Russell", "Jordan", "Dennis", "Warren", "Marvin", "Curtis", "Morris", "Chad", "Leonard", "Arthur", "Leroy", "Clarence", "Vincent", "Keith", "Gilbert", "Leon", "Francis", "Norman", "Leo", "Oscar", "Barry", "Joel", "Benny", "Herman", "Nathaniel", "Lester", "Jackie", "Gene", "Milton", "Allan", "Ernest", "Calvin", "Lyle", "Ray", "Edwin", "Harold", "Pete", "Jim", "Terry", "Charlie", "Glenn", "Eugene", "Bob", "Dean", "Melvin", "Stanley", "Alvin", "Sidney", "Maurice", "Bert", "Claude", "Erik", "Louis", "Roderick", "Lenny", "Ivan", "Maurice", "Billy", "Marvin", "Dale", "Emmett", "Jared", "Ronnie", "Clifford", "Nash", "Kurt", "Gilbert", "Wilfred", "Milton", "Mickey", "Roland", "Felix", "Terry", "Kenny", "Reggie", "Royce", "Elmer", "Angelo", "Jules", "Clyde", "Monty", "Randall", "Ricky", "Eddie", "Quincy", "Stan", "Tommy" };

			List <string> mufajok = new List<string>{ "Akció", "Kaland", "Animáció", "Képregény", "Bűnügyi", "Dokumentumfilm", "Dráma", "Romantikus", "Sci-fi", "Thriller", "Horror", "Komédia", "Művészfilm", "Történelmi", "Fantasy", "Zenei", "Western", "Szuperhős", "Sport", "War", "Tudományos", "Művészeti", "Musical", "Rejtély", "Krimi", "Kísértet", "Életrajzi", "Családi", "Felnőtt", "Szerelem", "Politikai", "Zsánerfilm", "Indie", "Csoportos", "Képregényfilm", "Romantikus vígjáték", "Pszichológiai thriller", "Tudományos fantasztikus", "Filozofikus", "Szatíra", "Paródia", "Túlélő", "Mindentudó", "Noir", "Gore", "Képregényadaptáció", "Drámai vígjáték", "Képregények", "Démoni", "Musical vígjáték", "Társadalmi dráma", "Felnőtt vígjáték", "Poszt-apokaliptikus", "Tudományos dráma", "Mítikus", "Születési történet", "Hóhér", "Hibás hős", "Tökéletes világ", "Képregényadaptáció", "Képregény vígjáték", "Gyilkosság", "Akció vígjáték", "Családi dráma", "Testvériség", "Zombis", "Romantikus dráma", "Kalandfilm", "Kreatív vígjáték", "Sötét humor", "Középiskolai dráma", "Kiborgos", "Posztmodern", "Alföldi", "Fekete komédia", "Történelmi dráma", "Börtönfilm", "Gyermekfilm", "Képregényes dráma", "Szépségverseny", "Modern városi", "Pszichodráma", "Búvárkodás", "Katona dráma", "Szerelem történet", "Film noir", "Túlvilági", "Képregényhősök", "Horror vígjáték", "Vámpíros", "Felfedezés", "Önvédelmi", "Játékfilm", "Képregényes akció", "Képregény adaptáció", "Kémfilm", "Birodalmi háborús", "Házastársi dráma", "Művészeti vígjáték", "Démoni dráma", "Képregényes vígjáték" };

			List <string> dijak = new List<string>{ "Academy Award", "Golden Globe", "Cannes Film Festival Palme d'Or", "BAFTA Award", "Screen Actors Guild Award", "Venice Film Festival Golden Lion", "César Award", "Critics' Choice Movie Award", "Saturn Award", "Teen Choice Award", "MTV Movie & TV Award", "Primetime Emmy Award", "Independent Spirit Award", "Tony Award", "Golden Raspberry Award", "Critics' Choice Television Award", "People's Choice Award", "Hugo Award", "Annie Award", "Berlin International Film Festival Golden Bear" };

			List  <string> gyartok = new List<string> { "Warner Bros.", "Universal Pictures", "Paramount Pictures", "20th Century Studios", "Columbia Pictures", "Sony Pictures", "Walt Disney Pictures", "Lionsgate Films", "New Line Cinema", "MGM Studios", "DreamWorks Pictures", "Metro-Goldwyn-Mayer", "Focus Features", "A24", "Pixar Animation Studios", "Legendary Entertainment", "Studio Ghibli", "Filmhansa", "Working Title Films", "Blue Sky Studios", "Lionsgate", "IFC Films", "Dimension Films", "Alliance Films", "TriStar Pictures", "Open Road Films", "EuropaCorp", "Screen Gems", "Cineworld", "Pathé", "Summit Entertainment", "TWC (The Weinstein Company)", "BBC Films", "Film4 Productions", "Koch Media", "Magnolia Pictures", "Walden Media", "Grindhouse Releasing", "Tartan Films", "Bleecker Street", "GKids", "Summit Entertainment", "Silver Pictures", "StudioCanal", "Newmarket Films", "Rogue Pictures", "Hammer Film Productions", "Eros International" };

			Random rnd = new Random();


			string cim = "";
			for (int i = 0; i < 3; i++)
			{
				cim += cimSzavak[rnd.Next(0, cimSzavak.Count)];
				cim += " ";
			}
			Console.WriteLine(cim);

			List<string> mufajai = new List<string>();
			for(int i = 0; i < 3; i++)
			{
                int sorsoltIndex = rnd.Next(0, mufajok.Count);
                mufajai.Add(mufajok[sorsoltIndex]);
                mufajok.RemoveAt(sorsoltIndex);
            }

			for(int i = 0;i < mufajai.Count;i++)
			{
				mufajok.Add(mufajai[i]);
			}

			int hossz = rnd.Next(0,400);

			string megjelenesDatum = "";

			int ev = rnd.Next(1880, 2025);
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


			
            Console.WriteLine(ev);
            Console.WriteLine(honap);
			Console.WriteLine(nap);
			
			/*
			for (int i = 0; i < 3; i++)
			{
				if (mufaj != temp)
				{
					mufajai.Add(mufaj);
				}
				else
				{
					mufaj = mufajok[rnd.Next(0, mufajok.Length)];
				}
				
			}

			for(int i = 0;i < mufajai.Count;i++)
			{
				Console.WriteLine(mufajai[i]);
			}*/






		}
	}
}
