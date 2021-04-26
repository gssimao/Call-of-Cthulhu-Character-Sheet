using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreation
{
    public partial class character : Form
    {
        public static readonly Random DiceRandom = new Random();
        public character()
        {
            InitializeComponent();
        }
        private void label22_Click(object sender, EventArgs e)
        {

        }
        private void Name_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }
        private void CharName_TextChanged(object sender, EventArgs e) // character name
        {

        }
        private void CharPlayer_TextChanged(object sender, EventArgs e) // player's name
        {

        }
        private void CharOccupation_TextChanged(object sender, EventArgs e) // Character Occupation
        {

        }
        private void CharResidence_TextChanged(object sender, EventArgs e) // character residence
        {

        }
        private void CharBirthplace_TextChanged(object sender, EventArgs e) // character birth place
        {

        }
        private void CharAge_TextChanged(object sender, EventArgs e) // character age
        {

        }
        private void CharSex_TextChanged(object sender, EventArgs e)// character sex
        {

        }
        private void CharMaxHP_TextChanged(object sender, EventArgs e) // character max HP
        {

        }
        private void CharCurrentHP_TextChanged(object sender, EventArgs e) // character current HP
        {

        }
        private void CharSTR_TextChanged(object sender, EventArgs e) // STR
        {

        }
        private void CharDex_TextChanged(object sender, EventArgs e) // DEX
        {

        }
        private void CharPow_TextChanged(object sender, EventArgs e) //POW
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e) // CON
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e) // APP
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e) // EDU
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e) // SIZE
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e) // INT
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e) // MOVE RATE
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void character_Load(object sender, EventArgs e)
        {

        }
        private void label27_Click(object sender, EventArgs e)
        {

        }
        //Skills section
        private void LawLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void RideLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void PsychoanalysisLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void PilotLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void PersuadeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void OpHvMachineLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void OccultLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void NavigateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void NaturalWorldLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void MedicineLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void MechRepairLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void LocksmithLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void ListenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void LibraryUseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void PsychologyLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        ////// input and ther stuff here
        private void CallDiceRoller_Click(object sender, EventArgs e) // Roll Dice
        {
            RollDice RollingDice = new RollDice();
            RollingDice.ShowDialog();

        }

        private void Female_CheckedChanged(object sender, EventArgs e) // Select Female character
        {
            if(Female.Checked)
            {
                Male.Checked = false;
            }
        }

        private void Male_CheckedChanged(object sender, EventArgs e) // Select Male character

        {
            if (Male.Checked)
            {
                Female.Checked = false;
            }
        }



        private void saveChar_Click(object sender, EventArgs e) // save character Button
        {
            //Character Investigator = new Character(CharName.ToString(), CharPlayer.ToString(), CharOccupation.ToString(), CharBirthplace.ToString(), CharResidence.ToString(), int.Parse(CharAge.Text));
  /*          Characteristic BaseCharacteristc = new Characteristic(CheckIfEmpty(CharSTR.ToString()), CheckIfEmpty(CharDEX.ToString()), CheckIfEmpty(CharPOW.ToString()),
                                                                  CheckIfEmpty(CharCON.ToString()), CheckIfEmpty(CharAPP.ToString()), CheckIfEmpty(CharEDU.ToString()),
                                                                  CheckIfEmpty(CharSIZ.ToString()), CheckIfEmpty(CharINT.ToString()), CheckIfEmpty(CharLuck.ToString()),
                                                                  CheckIfEmpty(CharMoveRate.ToString()));*/
               // I need a better solution for this part
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            //object InvestigatorPlayer;
            // InvestigatorPlayer = Activator.CreateInstance(CreateOccupation("Accountant"));
            string newOccupation = SelectOccupation();

            //OccupationList.Add(new Accountant(true) {CharName = "Steve"});
            List<Characteristic> OccupationList = new List<Characteristic>();
            OccupationList.Add(new Accountant(true));
            OccupationList.Add(new Acrobat(true));
            OccupationList.Add(new Actor(true));
            OccupationList.Add(new AgencyDetective(true));
            OccupationList.Add(new Alienist(true));
            //OccupationList.Add(new Acrobat(true));
            int index = DiceRandom.Next(OccupationList.Count); // chose a random from the list


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            ////////// I could make a list of all the skills and check for every skill in the occultist skill array. From there I need a function to show current points and mark the ones
            /// I have selected from the occupation list.
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //call on investigator propertites

            CharOccupation.Text = newOccupation;
            Notes.Text = "Suggested Skills\r" + OccupationList[index].SuggestedSkills + "\r" + "Contacts\r" + OccupationList[index].Contacts;
            CharBirthplace.Text = OccupationList[index].CharBirthplace;
            CharResidence.Text = OccupationList[index].CharResidence;
            CharAge.Text = OccupationList[index].CharAge.ToString();

            CharSTR.Text = OccupationList[index].charSTR.ToString();
            CharDEX.Text = OccupationList[index].charDEX.ToString();
            CharPOW.Text = OccupationList[index].charPOW.ToString();
            CharCON.Text = OccupationList[index].charCON.ToString();
            CharAPP.Text = OccupationList[index].charAPP.ToString();
            CharEDU.Text = OccupationList[index].charEDU.ToString();
            CharSIZ.Text = OccupationList[index].charSIZ.ToString();
            CharINT.Text = OccupationList[index].charINT.ToString();
            CharLuck.Text = OccupationList[index].charLuck.ToString();
            CharMoveRate.Text = OccupationList[index].charMoveRate.ToString();
            CharMaxHP.Text = OccupationList[index].charHP.ToString();
            CharCurrentHP.Text = OccupationList[index].charHP.ToString();
            CharSanity.Text = OccupationList[index].charPOW.ToString();
            CharMaxSanity.Text = OccupationList[index].charPOW.ToString();
            CharMP.Text = OccupationList[index].charMP.ToString();
            CharName.Text = OccupationList[index].CharName.ToString();
            if (OccupationList[index].CharSex == 1) // this is for the player's Sex choice. 1 is male 2 is female // to use later
            {
                Male.Checked = true;
                Female.Checked = false;
            }
            else if (OccupationList[index].CharSex == 2)
            {
                Female.Checked = true;
                Male.Checked = false;
            }
        }
        public int CheckIfEmpty(string num)
        {
            if (Int32.TryParse("num", out int CompleteParse))
            {
                return CompleteParse;
            }
            else
            {
                return 0;
            }
        }
        public string SelectOccupation()
        {
            string charOccupation = "";
            string[] Occupations = new string[]
                { "",
                    "Accountant",
                    "Acrobat",
                    "Actor",
                    "Film Star",
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
            charOccupation += Occupations[RollingDices(110)];

            return charOccupation;
        }
        
        //I'll have to make this a different way, maybe an if statement inside the form button?
        /*public Type CreateOccupation(string Occupation)
        {
            Occupation = Occupation.ToLower();
            switch (Occupation)
            {
                case "accountant":
                    Accountant AccountantPlayer = new Accountant();
                    return AccountantPlayer.GetType();

                case "acrobat":
                    Acrobat AcorbatPlayer = new Acrobat();
                    return AcorbatPlayer.GetType();

                case "actor":
                    Actor ActorPlayer = new Actor();
                    return ActorPlayer.GetType();

                case "agency detective":
                    break;

                case "alienist":
                    break;

                case "animal trainer":
                    break;

                case "atiquarian":
                    break;

                case "antique dealer":
                    break;

                case "archaeologist":
                    break;

                case "architect":
                    break;

                case "artist":

                    break;

                case "asylum attendant":
                    break;

                case "assassin":
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
                    Accountant Investigator = new Accountant();
                    return Investigator.GetType();
                    //Console.WriteLine("Nothing");
                    break;
            }
            
        } 
        */
        public int RollingDices(int max)
        {
            int roll;
            roll = DiceRandom.Next(1, max);
            return roll;
        }


    }
}
