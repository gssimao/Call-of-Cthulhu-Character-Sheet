using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class ForeignCorrespondent : Characteristic
    {
        public readonly string _occupationTitle = "Foreign Correspondent";

        public readonly string _creditRating = "10 - 40";
        public string _suggestedContacts = "National or worldwide news industry, foreign governments, military.";
        public string OccupationSkills = "History, Other Language, Own Language, Listen, two interpersonal skills(Charm, Fast Talk, Intimidate, or Persuade), Psychology, any one other skill as a personal or era specialty.";
        public int SelectMoreSkills = 0; 
        public ForeignCorrespondent()
        {
            SkillpointsAvailable = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        public ForeignCorrespondent(bool random) // this is a random accountant
        {
            CharAge = 0;
            creditRating = _creditRating;
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
            SkillpointsAvailable = calculateSkillPointsAvailable(_occupationName, CharSTR, CharDEX, CharPOW, CharCON, CharAPP, CharEDU, CharSIZ, CharINT);
        }

    }
}
