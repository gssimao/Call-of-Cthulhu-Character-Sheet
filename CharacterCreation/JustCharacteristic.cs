using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class JustCharacteristic : Characteristic
    {
        public readonly string _occupationTitle = "JustCharacteristic";
        
        public readonly string _creditRating = "";
        public readonly string _suggestedContacts = "";
        public string OccupationSkills = "";
        public JustCharacteristic()
        {
            RandomizeChar = true;
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

            //SkillpointsAvailable = calculateSkillPointsAvailable(_occupationName, this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }

    }
}
