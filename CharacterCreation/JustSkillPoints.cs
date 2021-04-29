using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class JustSkillPoints : Characteristic
    {
        private readonly string _occupationTitle = "JustSkillPoints";
        
        public readonly string _creditRating = "";
        public readonly string _suggestedContacts = " Select 8 Skills";
        public string OccupationSkills = "";
        public JustSkillPoints(string occupationName,int STR, int DEX, int POW, int CON , int APP, int SIZ, int EDU, int INT)
        {
            CharSTR = STR;
            CharDEX = DEX;
            CharPOW = POW;
            CharCON = CON;
            CharAPP = APP;
            CharEDU = EDU;
            CharSIZ = SIZ;
            CharINT = INT;
            SkillpointsAvailable = calculateSkillPointsAvailable(occupationName, this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }


    }
}
