using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class AgencyDetective : Characteristic
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

        public readonly string _creditRating = "20 - 45";
        public readonly string _suggestedContacts = "Local law enforcement, clients.";
        public string[] OccupationSkills = { "fast talk", "intimidate", "fighting", "firearms", "law", "library use", "psychology", "stealth", "track"};
        public int SelectMoreSkills = 0;
        public AgencyDetective()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        
        
    }
}
