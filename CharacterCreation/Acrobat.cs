using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Acrobat : Characteristic
    {
        public readonly string _occupationName = "Acrobat";

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

        public readonly string _creditRating = "5 - 20";
        public readonly string _suggestedContacts = "Amateur athletic circles, sports writers, circuses, carnivals.";
        public string[] OccupationSkills = { "climb", "dodge", "jump", "throw", "spot hidden", "swim"};
        public int SelectMoreSkills = 2;
        public Acrobat()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }

        public Acrobat(bool random) // this is a random accountant
        {
            //base character randomization
            CharName = SelectName();
            CharBirthplace = SelectBirthPlace();
            CharResidence = SelectResidence();

            //characteristic randomization
            int randomSet = 999;
            CharSTR = randomSet;
            CharDEX = randomSet;
            CharPOW = randomSet;
            CharCON = randomSet;
            CharAPP = randomSet;
            CharEDU = randomSet;
            CharSIZ = randomSet;
            CharINT = randomSet;
            CharLuck = randomSet;
            CharMoveRate = randomSet;
            CharMP = randomSet;
            CharHP = randomSet;

            //occupation point skill calculation
            OccupationSkillPoints = calculateSkillPointsAvailable(_occupationName, CharSTR, CharDEX, CharPOW, CharCON, CharAPP, CharEDU, CharSIZ, CharINT);
        }
    }
}
