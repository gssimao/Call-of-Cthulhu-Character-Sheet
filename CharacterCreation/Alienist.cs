using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Alienist : Characteristic
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

        public readonly string _creditRating = "10 - 60";
        public readonly string _suggestedContacts = "Others in the field of mental illness, medical doctors, and occasionally detectives in law enforcement.";
        public string[] OccupationSkills = { "law", "listen", "medicine", "other language", "psychoanalysis", "psychology", "biology", "chemistry"};
        public int SelectMoreSkills = 0;
        public Alienist()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        
        
    }
}
