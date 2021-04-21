using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Occupation : Character
    {
        public string _occupationName;
        public string OccupationName 
        {   get
            {
                return _occupationName;
            }
         
            set
            {
                _occupationName = value;
            }
        
        }

        public string _creditRating;
        public string CreditRating
        {
            get
            {
                return _creditRating;
            }

            set
            {
                _creditRating = value;
            }

        }

        public string _suggestedContacts;
        public string SuggestedContacts
        {
            get
            {
                return _suggestedContacts;
            }

            set
            {
                _suggestedContacts = value;
            }

        }

        public int _occupationSkillPoints;
        public int OccupationSkillPoints
        {
            get
            {
                return _occupationSkillPoints;
            }

            set
            {
                _occupationSkillPoints = value;
            }

        }

        public Occupation ()
        {
            
        }
        public string SelectOccupation()
        {
            string charOccupation = "";
            string[] Occupations = new string[]
                { "",
                    "Accountant",
                    "Acrobat",
                    "Actor",
                    "Agency Detective",
                    "Alienist",
                    "Animal Trainer",
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
        public void OccupationFormula(string Occupation)
        {
            Occupation = Occupation.ToLower();

            switch (Occupation)
            {
                case "accountant":
                    OccupationSkillPoints = this.charEDU * 4;
                    CreditRating = "30-70";
                    SuggestedContacts = "Business associates, legal professions, financial sectors (bankers, other accountants)";
                    break;

                case "acrobat":
                    OccupationSkillPoints = (this.charEDU * 2)+ (this.charDEX * 2);
                    CreditRating = "9-20";
                    SuggestedContacts = "Amateur Athletic circles, sports, writers, circuses, carnivals";
                    break;

                case "actor":
                    OccupationSkillPoints = (this.charEDU * 2) + (this.charAPP * 2);
                    CreditRating = "9-40";
                    SuggestedContacts = "Theatre industry, newspaper arts critic, actor's guild or union.";
                    break;

                case "agency detective":
                    int[] BiggestStat= { this.charDEX, this.charSTR};
                    OccupationSkillPoints = (this.charEDU * 2) + (BiggestStat.Max() * 2);
                    CreditRating = "20-45";
                    SuggestedContacts = "Local law enforcement, clients.";
                    break;

                case "alienist":
                    OccupationSkillPoints = this.charEDU * 4;
                    CreditRating = "10-60";
                    SuggestedContacts = "Others in the field of mental illness,medical doctors, and occasionally detectives in lawenforcement.";
                    break;

                case "animal trainer":
                    int[] BiggestStat2 = { this.charAPP, this.charPOW };
                    OccupationSkillPoints = (this.charEDU * 2) + (BiggestStat2.Max() * 2);
                    CreditRating = "10-40";
                    SuggestedContacts = "Zoos, circus folk, patrons, actors.";
                    break;

                case "atiquarian":
                    OccupationSkillPoints = this.charEDU * 4;
                    CreditRating = "30-70";
                    SuggestedContacts = "Booksellers, antique collectors, historical societies.";
                    break;

                case "antique dealer":
                    OccupationSkillPoints = this.charEDU * 4;
                    CreditRating = "30-50";
                    SuggestedContacts = "Local historians, other antique dealers, possibly criminal fences.";
                    break;

                case "archaeologist":
                    OccupationSkillPoints = this.charEDU * 4;
                    CreditRating = "10-40";
                    SuggestedContacts = "Patrons, museums, universities.";
                    break;

                case "architect":
                    OccupationSkillPoints = this.charEDU * 4;
                    CreditRating = "30-70";
                    SuggestedContacts = "Local building and city engineering departments, construction firms.";
                    break;

                case "artist":
                    int[] BiggestStat3 = { this.charDEX, this.charPOW };
                    OccupationSkillPoints = (this.charEDU * 2) + (BiggestStat3.Max() * 2);
                    CreditRating = "9-50";
                    SuggestedContacts = "Art galleries, critics, wealthy patrons, the advertising industry.";

                    break;

                case "asylum attendant":
                    int[] BiggestStat4 = { this.charSTR, this.charDEX };
                    OccupationSkillPoints = (this.charEDU * 2) + (BiggestStat4.Max() * 2);
                    CreditRating = "8-20";
                    SuggestedContacts = "Medical staff, patients, and relatives of patients. Access to medical records, as well as drugs and other medical supplies.";
                    break;

                case "assassin":
                    OccupationSkillPoints = (this.charDEX * 2) + (this.charSTR * 2);
                    CreditRating = "30-60";
                    SuggestedContacts = "Few, mostly underworld; people prefer not to know them too well.The best will have earned a formidable reputation on the street.";
                    break;

                case "author":

                    break;

                case "aviator":

                    break;

                case "bank robber":

                    break;

                case "bartender":

                    break;

                case "big game hunter":

                    break;

                case "book dealer":

                    break;

                case "bootlegger":

                    break;

                case "bounty hunter":

                    break;

                case "boxer/wrestler":

                    break;

                case "boxer":

                    break;

                case "wrestler":

                    break;

                case "burglar":

                    break;

                case "butler":

                    break;

                case "valet":

                    break;

                case "maid":

                    break;

                case "chauffeur":

                    break;

                case "computer programmer":

                    break;

                case "hacker":

                    break;

                case "computer programmer/hacker":

                    break;

                case "conman":

                    break;

                case "cowboy":

                    break;

                case "cowgirl":

                    break;
                case "cowboy/girl":

                    break;

                case "craftsperson":

                    break;

                case "criminal":

                    break;

                case "cult leader":

                    break;

                case "deprogrammer":

                    break;

                case "designer":

                    break;

                case "dilletante":

                    break;

                case "diver":

                    break;

                case "doctor of medicine":

                    break;

                case "drifter":

                    break;

                case "driver":

                    break;

                case "editor":

                    break;

                case "elected official":

                    break;

                case "enginner":

                    break;

                case "entertainer":

                    break;

                case "explorer":

                    break;

                case "farmer":

                    break;

                case "federal agent":

                    break;

                case "fence":

                    break;

                case "firefighter":

                    break;

                case "foreign correspondent":

                    break;

                case "forensic surgeon":

                    break;

                case "forger/counterfeiter":

                    break;

                case "counterfeiter":

                    break;

                case "forger":

                    break;

                case "gambler":

                    break;

                case "gangster":

                    break;

                case "gun Moll":

                    break;

                case "gentleman/lady":

                    break;

                case "gentleman":

                    break;

                case "lady":

                    break;

                case "hobo":

                    break;

                case "hospital Orderly":

                    break;

                case "journalist":

                    break;

                case "judge":

                    break;

                case "laboratory assistant":

                    break;

                case "laborer":

                    break;

                case "lawyer":

                    break;

                case "librarian":

                    break;

                case "lumberjack":

                    break;

                case "mechanic":

                    break;

                case "military Officer":

                    break;

                case "miner":

                    break;

                case "missionary":

                    break;

                case "mountain climber":

                    break;

                case "museum curator":

                    break;

                case "musician":

                    break;

                case "nurse":

                    break;

                case "occutist":

                    break;

                case "outdoorsman/outdoorswoman":

                    break;

                case "outdoorsman":

                    break;

                case "outdoorswoman":

                    break;

                case "parapsychologist":

                    break;

                case "pharmacist":

                    break;

                case "photographer":

                    break;

                case "photojournalist":

                    break;

                case "Pilot":

                    break;

                case "police detective/officer":

                    break;

                case "police detective":

                    break;

                case "officer":

                    break;

                case "private investigator":

                    break;

                case "professor":

                    break;

                case "prostitute":

                    break;

                case "psychiatrist":

                    break;

                case "psychologist/psychoanalyst":

                    break;

                case "psychologist":

                    break;

                case "psychoanalyst":

                    break;

                case "reporter":

                    break;

                case "researcher":

                    break;

                case "sailor":

                    break;

                case "salesperson":

                    break;

                case "secretary":

                    break;

                case "shopkeeper":

                    break;

                case "smuggler":

                    break;

                case "soldier/marine":

                    break;

                case "soldier":

                    break;

                case "marine":

                    break;

                case "spy":

                    break;

                case "street punk":

                    break;

                case "student/intern":

                    break;

                case "student":

                    break;

                case "intern":

                    break;

                case "stuntman":

                    break;

                case "taxi driver":

                    break;

                case "thug":

                    break;

                case "tribe member":

                    break;

                case "undertaker":

                    break;

                case "tribe Member":

                    break;

                case "union activist":

                    break;

                case "waitress/waiter":

                    break;

                case "waiter":

                    break;

                case "waitress":

                    break;

                case "white-collar worker":

                    break;

                case "zealot":

                    break;

                case "zookeeper":

                    break;

                default:
                    Console.WriteLine("Nothing");
                    break;
            }
        }
    }
}
