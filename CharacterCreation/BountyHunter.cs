using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class BountyHunter : Characteristic
    {
        public readonly string _occupationTitle = "Bounty Hunter";

        public readonly string _creditRating = "9 - 30";
        public string _suggestedContacts = "Bail bondsmen, local police, criminal informants.";
        public string OccupationSkills = "Drive Auto, Electronic or Electrical Repair, Fighting or Firearms, one interpersonal skill(Fast Talk, Charm, Intimidate, or Persuade), Law, Psychology, Track, Stealth.";
        public int SelectMoreSkills = 0;
        public BountyHunter()
        {
            SkillpointsAvailable = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        public BountyHunter(bool random) // this is a random accountant
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
