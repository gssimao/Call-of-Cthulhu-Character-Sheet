using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Accountant : Characteristic
    {
        public readonly string _occupationTitle = "Accountant";
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

        public readonly string _creditRating = "30 - 70";
        public readonly string _suggestedContacts = "Business associates, legal professions, financial sector(bankers, other accountants)";
        public string OccupationSkills = "accounting, law, library use, listen, persuade, spot hidden";
        public int SelectMoreSkills = 2;
        public Accountant()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(_occupationName, this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        public Accountant(bool random) // this is a random accountant
        {
            _occupationName = _occupationTitle;
            _suggestedSkills = OccupationSkills;
            Contacts = _suggestedContacts;
            CharSex = RollingDices(3);// 1 = male /// 2 = female;
            CharBirthplace = SelectBirthPlace();
            //base character randomization
            CharName = SelectName();
            CharResidence = SelectResidence();

            //characteristic randomization
            RandomizeChar = random;
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
