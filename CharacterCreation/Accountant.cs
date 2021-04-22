using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Accountant : Characteristic
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

        public readonly string _creditRating = "30 - 70";
        public readonly string _suggestedContacts = "Business associates, legal professions, financial sector(bankers, other accountants)";
        public string[] OccupationSkills = { "accounting", "law", "library use", "listen", "persuade", "spot hidden"};
        public int SelectMoreSkills = 2;
        public Accountant()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        
        
    }
}
