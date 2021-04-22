using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Acrobat : Characteristic
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

        public readonly string _creditRating = "5 - 20";
        public readonly string _suggestedContacts = "Amateur athletic circles, sports writers, circuses, carnivals.";
        public string[] OccupationSkills = { "climb", "dodge", "jump", "throw", "spot hidden", "swim"};
        public int SelectMoreSkills = 2;
        public Acrobat()
        {
            OccupationSkillPoints = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        
        
    }
}
