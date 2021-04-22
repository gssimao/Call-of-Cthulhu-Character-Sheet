using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Actor : Characteristic
    {
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

        public readonly string _creditRating = "9 - 40";
        public readonly string _suggestedContacts = "Theatre industry, newspaper arts critics, actor’s guild or union.";
        public string[] OccupationSkills = { "art/craft", "disguise", "fighting", "history", "charm", "persuade", "psychology"};
        public int SelectMoreSkills = 1;
        public Actor()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        
        
    }
}
