using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class AgencyDetective : Characteristic
    {
        public readonly string _occupationTitle = "Agency Detective";
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

        public readonly string _creditRating = "20 - 45";
        public readonly string _suggestedContacts = "Local law enforcement, clients.";
        public string[] OccupationSkills = { "fast talk", "intimidate", "fighting", "firearms", "law", "library use", "psychology", "stealth", "track"};
        public int SelectMoreSkills = 0;
        public AgencyDetective()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        public AgencyDetective(bool random) // this is a random accountant
        {
            _occupationName = _occupationTitle;
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
