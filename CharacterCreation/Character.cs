using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    internal class Character
    {
        public static readonly Random DiceRandom = new Random();
        public bool RandomizeChar = false;
       
        
        /*bool young = false;
        bool adult = false;
        bool old = false;*/


        string charName;
        public string CharName
        {
            get
            {
                return charName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && RandomizeChar == true)
                {
                    charName = SelectName();
                }
                else
                {
                    charName = value;
                }
            }
        }
        string charPlayer;
        public string CharPlayer
        {
            get
            {
                return charPlayer;
            }
            set
            {
                charPlayer = value;
            }
        }
        string charOccupation;
        public string CharOccupation
        {
            get
            {
                return charOccupation;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && RandomizeChar == true)
                {
                    charOccupation = SelectOccupation();
                }
                else
                {
                    charOccupation = value;
                }
            }
        }
        string charBirthplace;
        public string CharBirthplace
        {
            get
            {
                return charBirthplace;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && RandomizeChar == true)
                {
                    charBirthplace = SelectBirthPlace();
                }
                else
                {
                    charBirthplace = value;
                }
            }
        }
        string charResidence;
        public string CharResidence
        {
            get
            {
                return charResidence;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && RandomizeChar == true)
                {
                    charResidence = SelectResidence();
                }
                else
                {
                    charResidence = value;
                }
            }
        }
        int charAge;
        public int CharAge
        {
            get
            {
                return charAge;
            }
            set
            {
                if (value == 0 && RandomizeChar == true)
                {
                    charAge = RollingDices(61) + 14;
                }
                else
                {
                    charAge = value;
                }

            }
        }
        int charSex;
        public int CharSex
        {
            get
            {
                return charSex;
            }
            set
            {
                charSex = value;
            }
        }


        public Character(string charName, string charPlayer, string charOccupation, string charBirthplace, string charResidence, int charAge)
        {
            RandomizeChar = false;
            CharName = charName;
            CharPlayer = charPlayer;
            CharOccupation = charOccupation;
            CharBirthplace = charBirthplace;
            CharResidence = charResidence;
            CharAge = charAge;
        }

        public Character() // Create a randomized character
        {
            string empty = "";
            CharSex = RollingDices(3); // 1 = male /// 2 = female;
            RandomizeChar = true;
            CharOccupation = empty;
            CharBirthplace = empty;
            CharResidence = empty;
            CharAge = 0;
            CharName = empty;
            CharPlayer = empty;

        }

        string SelectName()
        {
            string name = "";
            if (CharSex == 1)
            {
                string[] MaleNames = new string[]
                { "",
                    "John",
                    "James",
                    "William",
                    "Charles",
                    "George",
                    "Joseph",
                    "Richard",
                    "Edward",
                    "Donald",
                    "Thomas",
                    "Frank",
                    "Harold",
                    "Paul",
                    "Raymond",
                    "Walter",
                    "Jack",
                    "Henry",
                    "Kenneth",
                    "Arthur",
                    "Albert",
                    "Harry",
                    "Eugene",
                    "Ralph",
                    "Howard",
                    "Willie",
                    "Fred",
                    "Francis",
                    "Herbert",
                    "Alfred",
                    "Norman",
                    "Gerald",
                    "Bernard",
                    "Melvin",
                    "Warren",
                    "Michael",
                    "Russell",
                    "Elmer",
                    "Lloyd",
                    "Vernon",
                    "Clyde",
                    "Chester",
                    "Philip",
                    "Alvin",
                    "Wayne",
                    "Lewis",
                    "Harvey",
                    "Maurice",
                    "David",
                    "Robert"}; // 50 names
                name += MaleNames[RollingDices(50)];
            }
            else if (CharSex == 2)
            {
                string[] FemaleNames = new string[]
                { "",
                    "Helen",
                    "Margaret",
                    "Ruth",
                    "Doris",
                    "France",
                    "Elizabeth",
                    "Anna",
                    "Alice",
                    "Jean",
                    "Barbara",
                    "Marjorie",
                    "Florence",
                    "Martha",
                    "Lillian",
                    "Louise",
                    "Ruby",
                    "Patricia",
                    "Gladys",
                    "Josephine",
                    "Edna",
                    "Norma",
                    "Lucille",
                    "Gloria",
                    "Ethel",
                    "Grace",
                    "June",
                    "Bernice",
                    "Dolores",
                    "Lorraine",
                    "Dorothy",
                    "Betty",
                    "Virgina",
                    "Mildred",
                    "Evelyn",
                    "Marie",
                    "Shirley",
                    "Irene",
                    "Lois",
                    "Rose",
                    "Catherine",
                    "Eleanor",
                    "Annie",
                    "Thelma",
                    "Pauline",
                    "Edith",
                    "Phyllis",
                    "Hazel",
                    "Rit",
                    "Mary"}; // 50 names
                name += FemaleNames[RollingDices(50)];
            }
            if (CharBirthplace == "Austria")
            {
                string[] AustriaSurnames = new string[]
                   { "",
                    "Gruber",
                    "Huber",
                    "Bauer",
                   "Müller",
                   "Steiner",
                    "Eder",
                    "Schneider",
                   "Wolf",
                   "Wimmer",
                   "Lechner"};
                name += " " + AustriaSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Belgium")
            {
                string[] BelgiumSurnames = new string[]
                   { "",
                    "Peeters",
                    "Janssens",
                    "Maes",
                   "Jacobs",
                   "Merterns",
                    "Willems",
                    "Claes",
                   "Goossens",
                   "Wouters",
                   "De Smet"};
                name += " " + BelgiumSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Croatia")
            {
                string[] CroatiaSurnames = new string[]
                   { "",
                    "Knežević",
                    "Horvat",
                    "Pavlović",
                   "Božić",
                   "Tomić",
                    "Filipović",
                    "Mandić",
                   "Nikolić",
                   "Lončar",
                   "Jukić"};
                name += " " + CroatiaSurnames[RollingDices(10)];

            }
            if (CharBirthplace == "Czechia")
            {
                string[] CzechiaSurnames = new string[]
                  { "",
                    "Ales",
                    "Balek",
                    "Duran",
                   "Havel",
                   "Fales",
                    "Dvorsky",
                    "Jun",
                   "Madera",
                   "Sladek",
                   "Tatar"};
                name += " " + CzechiaSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Denmark")
            {
                string[] DenmarkSurnames = new string[]
                  { "",
                    "Nielsen",
                    "Jensen",
                    "Hansen",
                   "Andersen",
                   "Pedersen",
                    "Christensen",
                    "Larsen",
                   "Rasmussen",
                   "Madsen",
                   "Kristensen"};
                name += " " + DenmarkSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Estonia")
            {
                string[] estoniaSurnames = new string[]
                  { "",
                    "Aasmäe",
                    "Alver",
                    "Eskola",
                   "Kütt",
                   "Peetre",
                    "Mölder",
                    "Lepp",
                   "Käsper",
                   "Kallas",
                   "Salumets"};
                name += " " + estoniaSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Finland")
            {
                string[] FinlandSurnames = new string[]
                  { "",
                    "Korhonen",
                    "Virtanen",
                    "Nieminen",
                   "Mäkinen",
                   "Hämäläinen",
                    "Laine",
                    "Heikkinen",
                   "Jävinen",
                   "Lehtinen",
                   "Saarinen"};
                name += " " + FinlandSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "France")
            {
                string[] FranceSurnames = new string[]
                  { "",
                    "Martin",
                    "Bernard",
                    "Durand",
                   "Dubois",
                   "Moreau",
                    "Simon",
                    "Laurent",
                   "Michel",
                   "Roux",
                   "Dupont"};
                name += " " + FranceSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "England")
            {
                string[] Surnames = new string[]
              { "",
                    "Ankins",
                    "Baker",
                    "Belanger",
                    "Bhenki",
                    "Click",
                    "Collins",
                    "Crankovitch",
                    "Darwin",
                    "Dorman",
                    "English",
                    "Fandrick",
                    "Felten",
                    "Finley",
                    "Franklin",
                    "Garvin",
                    "Greenwalt",
                    "Hahn",
                    "Hass",
                    "Heminger",
                    "Hilt",
                    "Kloburcher",
                    "Levard",
                    "Lynch",
                    "McBurney",
                    "McDonald",
                    "Morris",
                    "Nickels",
                    "O'Neil",
                    "Peppin",
                    "Porter",
                    "Price",
                    "Rossini",
                    "Schwarm",
                    "Schwartz",
                    "Simmons",
                    "Shirley",
                    "St. Dennis",
                    "Tenker",
                    "Webber",
                    "Westin",
                    "White",
                    "Winters",
                    "Woods",
                    "Zibart",
                    "Wall",
                    "Walsted",
                    "Yeske",
                    "Strong",
                    "Swanson"}; // 50 names
                name += " " + Surnames[RollingDices(50)];
            }
            if (CharBirthplace == "Bulgaria")
            {
                string[] BulgariaSurnames = new string[]
                  { "",
                    "Andonov",
                    "Balek",
                    "Duran",
                   "Havel",
                   "Fales",
                    "Dvorsky",
                    "Jun",
                   "Madera",
                   "Sladek",
                   "Tatar"};
                name += " " + BulgariaSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Germany")
            {
                string[] GermanySurnames = new string[]
                  { "",
                    "Ales",
                    "Blagoev",
                    "Chirkov",
                   "Demirev",
                   "Filipov",
                    "Goranov",
                    "Hagi",
                   "Ivanoff",
                   "Kovacheva",
                   "Shopov"};
                name += " " + GermanySurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Greece")
            {
                string[] GreeceSurnames = new string[]
                  { "",
                    "Vlachos",
                    "Makris",
                    "Georgiou",
                   "Pappas",
                   "Paradimitrious",
                    "Oikonomou",
                    "Alexiou",
                   "Nikolaidis",
                   "Antonopoulos",
                   "Mylonas"};
                name += " " + GreeceSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Hungary")
            {
                string[] HungarySurnames = new string[]
                  { "",
                    "Aper",
                    "Balazs",
                    "Belko",
                   "Adami",
                   "Nemes",
                    "Pogany",
                    "Orsi",
                   "Rigo",
                   "Sarlo",
                   "Petro"};
                name += " " + HungarySurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Ireland")
            {
                string[] IrelandSurnames = new string[]
                  { "",
                    "Murphy",
                    "O'Sullivan",
                    "Walsh",
                   "O'Brien",
                   "Byrne",
                    "Ryan",
                    "O'Connor",
                   "O'Neil",
                   "O'Reilly",
                   "Kelly"};
                name += " " + IrelandSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Italy")
            {
                string[] ItalySurnames = new string[]
                  { "",
                    "Rossi",
                    "Ferrari",
                    "Esposito",
                   "Bianchi",
                   "Romano",
                    "Colombo",
                    "Ricci",
                   "Gallo",
                   "Costa",
                   "De Luca"};
                name += " " + ItalySurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Luxembourg")
            {
                string[] LuxembourgSurnames = new string[]
                  { "",
                    "Schmit",
                    "Muller",
                    "Weber",
                   "Hoffmann",
                   "Wagner",
                    "Klein",
                    "Becker",
                   "Kremer",
                   "Faber",
                   "Meyer"};
                name += " " + LuxembourgSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Netherlands")
            {
                string[] NetherlandsSurnames = new string[]
                  { "",
                    "De Jong",
                    "Jansen",
                    "De Vries",
                   "Van de Berg",
                   "Van Dijk",
                    "Bakker",
                    "Janssen",
                   "Visser",
                   "Smit",
                   "Meijer"};
                name += " " + NetherlandsSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Poland")
            {
                string[] PolandSurnames = new string[]
                  { "",
                    "Nowak",
                    "Kowalski",
                    "Kaminski",
                   "Wozniak",
                   "Grabowski",
                    "Pawlowski",
                    "Michalski",
                   "Dudek",
                   "Zajac",
                   "Majewski"};
                name += " " + PolandSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Brazil")
            {
                string[] BrazilSurnames = new string[]
                  { "",
                    "Almeida",
                    "Carvalho",
                    "Melo",
                   "Sales",
                   "Barbosa",
                    "Pereira",
                    "Santos",
                   "Rocha",
                   "Lima",
                   "Silva"};
                name += " " + BrazilSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Portugal")
            {
                string[] PortugalSurnames = new string[]
                  { "",
                    "Teixeira",
                    "Dias",
                    "Fernandes",
                   "Correia",
                   "Gomes",
                    "Costa",
                    "Alves",
                   "Silva",
                   "Santos",
                   "Ferreira"};
                name += " " + PortugalSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Romania")
            {
                string[] RomaniaSurnames = new string[]
                  { "",
                    "Andrei",
                    "Barbu",
                    "Cojocaru",
                   "Dan",
                   "Dragavei",
                    "Eder",
                    "Fischer",
                   "Hofer",
                   "Luca",
                   "Maier"};
                name += " " + RomaniaSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Slovakia")
            {
                string[] SlovakiaSurnames = new string[]
                  { "",
                    "Novák",
                    "Svoboda",
                    "Novotný",
                   "Dvořák",
                   "Černý",
                    "Procházka",
                    "Kučera",
                   "Veselý",
                   "Horák",
                   "Němec"};
                name += " " + SlovakiaSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Spain")
            {
                string[] SpainSurnames = new string[]
                  { "",
                    "Rodríguez",
                    "Ontivero",
                    "González",
                   "Hernández",
                   "García",
                    "Martinez",
                    "Fredrick",
                   "Fernández",
                   "Ruiz",
                   "Romero"};
                name += " " + SpainSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Sweden")///////////////////////////////////////////////////////// stopped here
            {
                string[] SwedenSurnames = new string[]
                  {  "",
                    "Andersson",
                    "Johansson",
                    "Karlsson",
                   "Nilsson",
                   "Eriksson",
                    "Larsson",
                    "Olsson",
                   "Persson",
                   "Svensson",
                   "Gustafsson"};
                name += " " + SwedenSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "United States")
            {
                string[] UnitedStatesSurnames = new string[]
                  { "",
                    "Smith",
                    "Jonhson",
                    "Brown",
                   "Jones",
                   "Garcia",
                    "Miller",
                    "Hernandex",
                   "Lopez",
                   "Williams",
                   "Rodrigues"};
                name += " " + UnitedStatesSurnames[RollingDices(10)];
            }
            if (CharBirthplace == "Mexico")
            {
                string[] MexicoSurnames = new string[]
                  { "",
                    "González",
                    "Martínez",
                    "López",
                   "Pérez",
                   "Garcia",
                    "Miller",
                    "Hernandex",
                   "Lopez",
                   "Sánchez",
                   "Rodrigues"};
                name += " " + MexicoSurnames[RollingDices(10)];
            }
            return name;
        }
        string SelectOccupation()
        {
            string charOccupation = "";
            string[] Occupations = new string[]
                { "",
                    "Accountant",
                    "Acrobat",
                    "Actor",
                    "Agency Detective",
                    "Alienist",
                    "Animl Trainer",
                    "Atiquarian",
                    "Antique Dealer",
                    "Archaeologist",
                    "Architect",
                    "Artist",
                    "Asylum Attendant",
                    "Assassin",
                    "Athlete",
                    "Author",
                    "Aviator",
                    "Bank Robber",
                    "Bartender",
                    "Big Game Hunter",
                    "Book Dealer",
                    "Bootlegger",
                    "Bounty Hunter",
                    "Boxer/Wrestler",
                    "Burglar",
                    "Butler/Valet/Maid",
                    "Chauffeur",
                    "Computer Programmer/Hacker",
                    "Conman",
                    "Cowboy/girl",
                    "Craftsperson",
                    "Criminal",
                    "Cult Leader",
                    "Deprogrammer",
                    "Designer",
                    "Dilletante",
                    "Diver",
                    "Doctor of Medicine",
                    "Drifter",
                    "Driver",
                    "Editor",
                    "Elected Official",
                    "Enginner",
                    "Entertainer",
                    "Explorer",
                    "Farmer",
                    "Federal Agent",
                    "Fence",
                    "Firefighter",
                    "Foreign Correspondent",
                    "Forensic Surgeon",
                    "Forger/Counterfeiter",
                    "Gambler",
                    "Gangster",
                    "Gun Moll",
                    "Gentleman/Lady",
                    "Hacker",
                    "Hobo",
                    "Hospital Orderly",
                    "Journalist",
                    "Judge",
                    "Laboratory Assistant",
                    "Laborer",
                    "Lawyer",
                    "Librarian",
                    "Lumberjack",
                    "Maid",
                    "Mechanic",
                    "Military Officer",
                    "Miner",
                    "Missionary",
                    "Mountain Climber",
                    "Museum Curator",
                    "Musician",
                    "Nurse",
                    "Occutist",
                    "Outdoorsman/Outdoorswoman",
                    "Parapsychologist",
                    "Pharmacist",
                    "Photographer",
                    "Photojournalist",
                    "Pilot",
                    "Police Detective/Officer",
                    "Private Investigator",
                    "Professor",
                    "Prostitute",
                    "Psychiatrist",
                    "Psychologist/Psychoanalyst",
                    "Reporter",
                    "Researcher",
                    "Sailor",
                    "Salesperson",
                    "Secretary",
                    "Shopkeeper",
                    "Smuggler",
                    "Soldier/Marine",
                    "Spy",
                    "Street Punk",
                    "Student/Intern",
                    "Stuntman",
                    "Taxi Driver",
                    "Thug",
                    "Tribe Member",
                    "Undertaker",
                    "Union Activist",
                    "Valet",
                    "Waitress/Waiter",
                    "White-collar Worker",
                    "Zealot",
                    "Zookeeper"}; // 50 names
            charOccupation += Occupations[RollingDices(109)];

            return charOccupation;
        }
        string SelectBirthPlace()
        {
            string charBirhtPlace = "";
            string[] Locations = new string[]
                { "",
                    "Austria",
                    "Belgium",
                    "Bulgaria",
                    "Croatia",
                    "Czechia",
                    "Denmark",
                    "Estonia",
                    "Finland",
                    "France",
                    "England",
                    "Germany",
                    "Greece",
                    "Hungary",
                    "Ireland",
                    "Italy",
                    "Luxembourg",
                    "Netherlands",
                    "Poland",
                    "Brazil",
                    "Portugal",
                    "Romania",
                    "Slovakia",
                    "Spain",
                    "Sweden",
                    "United States",
                    "Mexico"}; // 26 countries
            charBirhtPlace += Locations[RollingDices(26)];

            return charBirhtPlace;
        }
        string SelectResidence()
        {
            string charResidense = "";
            string[] Locations = new string[]
                { "",
                    "Austria",
                    "Belgium",
                    "Bulgaria",
                    "Croatia",
                    "Czechia",
                    "Denmark",
                    "Estonia",
                    "Finland",
                    "France",
                    "England",
                    "Germany",
                    "Greece",
                    "Hungary",
                    "Ireland",
                    "Italy",
                    "Luxembourg",
                    "Netherlands",
                    "Poland",
                    "Brazil",
                    "Portugal",
                    "Romania",
                    "Slovakia",
                    "Spain",
                    "Sweden",
                    "United States",
                    "Mexico"}; // 26 countries
            charResidense += Locations[RollingDices(26)];

            return charResidense;
        }
        public int CalculateMagicPoint(int POW)
        {
            int calc = (int)Math.Floor((float)POW / 5);
            return calc;
        }
        public string CalculateDamageBonus(int STR, int SIZ)
        {
            int combine = STR + SIZ;
           if(combine <= 64)
            {
                return "-2";
            }
           else if(combine >= 65 && combine <= 84 )
            {
                return "-1";
            }
            else if (combine >= 85 && combine <= 124)
            {
                return "None";
            }
            else if (combine >= 125 && combine <= 164)
            {
                return "+1D4";
            }
            else if (combine >= 165)
            {
                return "+1D6";
            }
            return "";
        }
        public string CalculateBuild(int STR, int SIZ)
        {
            int combine = STR + SIZ;
            if (combine <= 64)
            {
                return "-2";
            }
            else if (combine >= 65 && combine <= 84)
            {
                return "-1";
            }
            else if (combine >= 85 && combine <= 124)
            {
                return "None";
            }
            else if (combine >= 125 && combine <= 164)
            {
                return "+1";
            }
            else if (combine >= 165)
            {
                return "+2";
            }
            return "";
        }
        public int CalculateHP(int SIZ, int CON)
        {
            int calc = (int)Math.Floor(((float)SIZ + CON)/10);
            return calc;
        }
        public int CalculateMoveRate(int STR, int DEX, int SIZ)
        {
            int mov = 0;
            if (CharAge > 40)
            {
                mov = -1;
            }
            if (STR < SIZ && STR < SIZ)
            {
                mov += 7;
            }
            else if(STR >= SIZ || DEX >= SIZ)
            {
                mov += 8;
            }
            else if (STR > SIZ && DEX > SIZ)
            {
                mov += 9;
            }
            return mov;
        }
        public int RollingDices(int max)
        {
            int roll;
            roll = DiceRandom.Next(1, max);
            return roll;
        }

    }
}
