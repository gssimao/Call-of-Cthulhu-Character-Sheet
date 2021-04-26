using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class AnimalTrainer : Characteristic
    {
        public readonly string _occupationTitle = "AnimalTrainer";
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

        public readonly string _creditRating = "10 - 40";
        public readonly string _suggestedContacts = "Zoos, cicus, folk, patrons, actors";
        public string[] OccupationSkills = { "jump", "listen", "natural world", "psychology", "science", "stealth", "track"};
        public int SelectMoreSkills = 1;
        public AnimalTrainer()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        public AnimalTrainer(bool random) // this is a random accountant
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
