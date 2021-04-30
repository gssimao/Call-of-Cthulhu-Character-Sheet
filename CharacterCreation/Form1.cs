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
    public partial class character : Form , IRandomizer
    {
        public int totalSkill = 0;
        bool notesSet = false;
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


        ///Skills here
        private void ElecRepairSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void DriveSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void DodgeSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void DisguiseSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void MythosSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void CreditRatingSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void ClimbSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void CharmSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank2Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank1Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void ArtCraftSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void ArchaeologySkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void AppraiseSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void nthropologySkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void AccountingSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void CthulhuMythosLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void OwnLanguageSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank7Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank6Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void LanguageSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void JumpSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void IntimidateSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void HistorySkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void FirstAidSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank5Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void HeavyFirearmSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void FirearmSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank4Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank3Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void FightingSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void FastTalkSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void RideSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void PsychoanalysisSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void PsychologySkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void PilotSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void PersuadeSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void OpHvMachineSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void OccultSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void NavigateSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void NatWorldSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void MedicineSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void MechRepairSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void LocksmithSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void ListenSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void LibraryUseSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void LawSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank14Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank13Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank12Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank11Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank10Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void TrackSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void ThrowSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void SwimSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void SurvivalSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void StealthSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void SpotHiddenSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void SleightOfHandSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank9Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void Blank8Skill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }

        private void ScienceSkill_TextChanged(object sender, EventArgs e)
        {
            SkillPointsToUse.Text = CompareSkillsLeft().ToString();
        }
        /// skills ends

        //skill links
        private void AccountingLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(AccountingLabel);
        }

        private void ArtCrftLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(ArtAndCrftLabel);
        }

        private void ArchaeologyLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(ArchaeologyLabel);
        }

        private void AppraiseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(AppraiseLabel);
        }

        private void AnthropologyLabal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(AnthropologyLabal);
        }

        private void ElecRepairLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(ElecRepairLabel);
        }

        private void DriveAutoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(DriveAutoLabel);
        }

        private void DodgeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(Dodge12Label);
        }

        private void DisguiseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(DisguiseLabel);
        }

        private void CreditRatingLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(CreditRatingLabel);
        }

        private void ClimbLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(Climb12Label);
        }

        private void CharmLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(Charm12Label);
        }

        private void LanguageOwnLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(LanguageOwnLabel);
        }

        private void LanguageLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(LanguageOtherLabel);
        }

        private void JumpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(Jump123Label);
        }

        private void IntimidateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(IntimidateLabel);
        }

        private void HistoryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(HistoryLabel);
        }

        private void FirstAidLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(FirstAidLabel);
        }

        private void FirearmHeavyLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(FirearmHeavyLabel);
        }

        private void FireamsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(FireamsLabel);
        }

        private void FightingLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(FightingLabel);
        }

        private void FastTalkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(FastTalkLabel);
        }

        private void ScienceLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(ScienceLabel);
        }

        private void TrackLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(Track12Label);
        }

        private void ThrowLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(Throw12Label);
        }

        private void SwimLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(Swim123Label);
        }

        private void SurvivalLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(SurvivalLabel);
        }

        private void StealthLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(StealthLabel);
        }

        private void SpotHiddenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(SpotHiddenLabel);
        }

        private void SleightofHandLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckFails(SleightofHandLabel);
        }
        private void SkillPointsLeft_TextChanged(object sender, EventArgs e)
        {

        }
        /// skill links end
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



        private void saveChar_Click(object sender, EventArgs e) // randomize Characteristics Only
        {
            JustCharacteristic Investigator = new JustCharacteristic();

            CharSTR.Text = Investigator.charSTR.ToString();
            CharDEX.Text = Investigator.charDEX.ToString();
            CharPOW.Text = Investigator.charPOW.ToString();
            CharCON.Text = Investigator.charCON.ToString();
            CharAPP.Text = Investigator.charAPP.ToString();
            CharEDU.Text = Investigator.charEDU.ToString();
            CharSIZ.Text = Investigator.charSIZ.ToString();
            CharINT.Text = Investigator.charINT.ToString();

        }
        private void CalculateSkillPoint_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CharSTR.Text) || String.IsNullOrEmpty(CharDEX.Text) || String.IsNullOrEmpty(CharPOW.Text) || String.IsNullOrEmpty(CharCON.Text) || String.IsNullOrEmpty(CharAPP.Text) || String.IsNullOrEmpty(CharEDU.Text) || String.IsNullOrEmpty(CharINT.Text))
            {
                Notes.Text = "fill all of your Characteristics to start calculation STR, DEX, POW, CON, APP, EDU, and INT";
                notesSet = false;
            }
            else if (String.IsNullOrEmpty(CharOccupation.Text))
            {
                Notes.Text = "You need an Occupation to start, you can check all occupations in the Book Call of Cthulhu 7E or trying the Randomize All Button";
                notesSet = false;
            }
            else
            {
                if (int.TryParse(CharSTR.Text, out int STR));
                if (int.TryParse(CharDEX.Text, out int DEX));
                if (int.TryParse(CharPOW.Text, out int POW));
                if (int.TryParse(CharCON.Text, out int CON));
                if (int.TryParse(CharAPP.Text, out int APP));
                if (int.TryParse(CharEDU.Text, out int EDU));
                if (int.TryParse(CharINT.Text, out int INT));
                int SIZ = 0;
                if(!notesSet)
                {
                    Notes.Text = "Notes";
                }
               JustSkillPoints Investigator = new JustSkillPoints(CharOccupation.Text ,STR, DEX, POW, CON, APP, SIZ, EDU, INT);
                SkillPointsLeft.Text = Investigator.SkillpointsAvailable.ToString();
                SkillPointsToUse.Text = Investigator.SkillpointsAvailable.ToString();
                totalSkill = Investigator.SkillpointsAvailable;
            }
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            //string newOccupation = SelectOccupation();

            List<Characteristic> OccupationList = new List<Characteristic>();
            OccupationList.Add(new Accountant(true));
            OccupationList.Add(new Acrobat(true));
            OccupationList.Add(new Actor(true));
            OccupationList.Add(new AgencyDetective(true));
            OccupationList.Add(new Alienist(true));
            OccupationList.Add(new Antiquarian(true));
            OccupationList.Add(new AntiqueDealer(true));
            OccupationList.Add(new Archaeologist(true));
            OccupationList.Add(new Architect(true));
            OccupationList.Add(new Artist(true));
            OccupationList.Add(new AsylumAttendant(true));
            OccupationList.Add(new Athlete(true));
            OccupationList.Add(new Author(true));
            OccupationList.Add(new Bartender(true));
            OccupationList.Add(new BigGameHunter(true));
            OccupationList.Add(new BountyHunter(true));
            OccupationList.Add(new BookDealer(true));
            OccupationList.Add(new Boxer(true));
            OccupationList.Add(new Butler(true));
            OccupationList.Add(new Clergy(true));
            OccupationList.Add(new ComputerProgrammer(true));
            OccupationList.Add(new Cowboy(true));
            OccupationList.Add(new Cowgirl(true));
            OccupationList.Add(new Craftsperson(true));
            OccupationList.Add(new Assassin(true));
            OccupationList.Add(new BankRobber(true));
            OccupationList.Add(new Bootlegger(true));
            OccupationList.Add(new Thug(true));
            OccupationList.Add(new Burglar(true));
            OccupationList.Add(new Fence(true));
            OccupationList.Add(new Conman(true));
            OccupationList.Add(new Forger(true));
            OccupationList.Add(new Counterfeiter(true));
            OccupationList.Add(new Smuggler(true));
            OccupationList.Add(new Criminal(true));
            OccupationList.Add(new StreetPunk(true));
            OccupationList.Add(new GunMoll(true));
            OccupationList.Add(new CultLeader(true));
            OccupationList.Add(new Designer(true));
            OccupationList.Add(new Driver(true));
            OccupationList.Add(new DoctorOfMedicine(true));
            OccupationList.Add(new Editor(true));
            OccupationList.Add(new ElectedOfficial(true));
            OccupationList.Add(new Engineer(true));
            OccupationList.Add(new Entertainer(true));
            OccupationList.Add(new Explorer(true));
            OccupationList.Add(new Farmer(true));
            OccupationList.Add(new FederalAgent(true));
            OccupationList.Add(new FireFighter(true));
            OccupationList.Add(new ForeignCorrespondent(true));
            OccupationList.Add(new ForeignCorrespondent(true));
            OccupationList.Add(new Gambler(true));
            OccupationList.Add(new Gangster(true));
            OccupationList.Add(new Gentleman(true));
            OccupationList.Add(new Lady(true));
            OccupationList.Add(new Hobo(true));
            OccupationList.Add(new HospitalOrderly(true));
            OccupationList.Add(new Journalist(true));
            OccupationList.Add(new Judge(true));
            OccupationList.Add(new LaboratoryAssistant(true));
            OccupationList.Add(new Laborer(true));
            OccupationList.Add(new Miner(true));
            OccupationList.Add(new Lumberjack(true));
            OccupationList.Add(new Lawyer(true));
            OccupationList.Add(new Mechanic(true));
            OccupationList.Add(new MilitaryOfficer(true));
            OccupationList.Add(new Miner(true));
            OccupationList.Add(new Missionary(true));
            OccupationList.Add(new MountainClimber(true));
            OccupationList.Add(new MuseumCurator(true));
            OccupationList.Add(new Musician(true));
            OccupationList.Add(new Nurse(true));
            OccupationList.Add(new Occultist(true));
            OccupationList.Add(new Outdoorsman(true));
            OccupationList.Add(new Outdoorswoman(true));
            OccupationList.Add(new Aviator(true));
            OccupationList.Add(new Parapsychologist(true));
            OccupationList.Add(new Pharmacist(true));
            OccupationList.Add(new Photographer(true));
            OccupationList.Add(new Pilot(true));
            OccupationList.Add(new PoliceDetective(true));
            OccupationList.Add(new Psychoanalyst(true));
            OccupationList.Add(new Psychologist(true));
            OccupationList.Add(new Researcher(true));
            OccupationList.Add(new Prostitute(true));
            OccupationList.Add(new Marine(true));
            OccupationList.Add(new Intern(true));
            OccupationList.Add(new Sailor(true));
            OccupationList.Add(new Scientist(true));
            OccupationList.Add(new Salesperson(true));
            OccupationList.Add(new Secretary(true));
            OccupationList.Add(new Shopkeeper(true));
            OccupationList.Add(new Smuggler(true));
            OccupationList.Add(new Soldier(true));
            OccupationList.Add(new Spy(true));
            OccupationList.Add(new Student(true));
            OccupationList.Add(new Stuntman(true));
            OccupationList.Add(new TribeMember(true));
            OccupationList.Add(new Undertaker(true));
            OccupationList.Add(new UnionActivist(true));
            OccupationList.Add(new Waitress(true));
            OccupationList.Add(new WhiteCollarWorker(true));
            OccupationList.Add(new Zealot(true));
            OccupationList.Add(new Zookeeper(true));


            int index = DiceRandom.Next(OccupationList.Count); // chose a random from the list

            CharOccupation.Text = OccupationList[index]._occupationName;
            Notes.Text = "Suggested Skills\r" + OccupationList[index].SuggestedSkills + "\r" + "Contacts\r" + OccupationList[index].Contacts;
            notesSet = true;
            CharBirthplace.Text = OccupationList[index].CharBirthplace;
            CharResidence.Text = OccupationList[index].CharResidence;

            CharAge.Text = OccupationList[index].CharAge.ToString();
            CreditRatingSkill.Text = OccupationList[index].creditRating;

            SkillPointsLeft.Text = OccupationList[index].SkillpointsAvailable.ToString();
            SkillPointsToUse.Text = OccupationList[index].SkillpointsAvailable.ToString();

            totalSkill = OccupationList[index].SkillpointsAvailable;
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
            return 0;
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

        public int RollingDices(int max)
        {
            int roll;
            roll = DiceRandom.Next(1, max);
            return roll;
        }


        public int CompareSkillsLeft()
        {
            int newTotal = 0;
            foreach (Control f in this.Controls)
            {
                if (f is TextBox)
                {
                    string Name = f.Name.ToString(); // grab the name of the textBox
                    string Last5Digits = Name.Substring(Name.Length - 5); // check the last 5 digits and save it 
                    if (Last5Digits == "Skill") // if the last 5 Digits are == Skill than its a skill
                    {
                        if (int.TryParse(f.Text, out int skill)) // see if there are any numbers in there and convert them into an int
                        {
                            newTotal += skill; // store them in new total
                        }
                    }
                }
            }
            return totalSkill - newTotal; // amount of skill points left to be assigned
        }

        public void CheckFails(LinkLabel Skill)
        {
            int fail = 0;
            int critFail = 0;
            string Name = Skill.Name;
            string Compare1 = new string(Name.Take(7).ToArray());

            foreach (Control f in this.Controls)
            {
                if (f is TextBox)
                {
                    string TextBoxName = f.Name.ToString();
                    string Compare2 = new string(TextBoxName.Take(7).ToArray());
                    if (Compare1 == Compare2)
                    {
                        if (int.TryParse(f.Text, out int skill))
                        {
                            fail = (int)Math.Floor((double)(skill / 2));
                            critFail = (int)Math.Floor((double)(skill / 5));
                        }
                    }
                }
            }
            FailCheck.Text = fail.ToString();
            FifthValue.Text = critFail.ToString();
            SkillName.Text = Skill.Name;
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



    }
}
