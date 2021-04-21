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
            /*Character Investigator = new Character();
            CharName.Text = Investigator.CharName;
            CharOccupation.Text = Investigator.CharOccupation;
            CharBirthplace.Text = Investigator.CharBirthplace;
            CharResidence.Text = Investigator.CharResidence;
            CharAge.Text = Investigator.CharAge.ToString();

            CharSTR.Text = Investigator.charSTR.ToString();
            CharDEX.Text = Investigator.charDEX.ToString();
            CharPOW.Text = Investigator.charPOW.ToString();
            CharCON.Text = Investigator.charCON.ToString();
            CharAPP.Text = Investigator.charAPP.ToString();
            CharEDU.Text = Investigator.charEDU.ToString();
            CharSIZ.Text = Investigator.charSIZ.ToString();
            CharINT.Text = Investigator.charINT.ToString();
            CharLuck.Text = Investigator.charLuck.ToString();
            CharMoveRate.Text = Investigator.charMoveRate.ToString();
            CharMaxHP.Text = Investigator.charHP.ToString();
            CharCurrentHP.Text = Investigator.charHP.ToString();
            CharSanity.Text = Investigator.charPOW.ToString();
            CharMaxSanity.Text = Investigator.charPOW.ToString();
            CharMP.Text = Investigator.charMP.ToString();*/


           /* if (Investigator.CharSex == 1) // this is for the player's Sex choice. 1 is male 2 is female // to use later
            {
                Male.Checked = true;
                Female.Checked = false;
            }
            else if (Investigator.CharSex == 2)
            {
                Female.Checked = true;
                Male.Checked = false;
            }*/
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


    }
}
