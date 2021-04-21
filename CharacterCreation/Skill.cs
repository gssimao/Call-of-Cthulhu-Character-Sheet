using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Skill : Character
    {
        public string SkillName{get;set;}

        public int points;
        public int Points
        {
            get
            {
                return points;
            }
            set
            {
                if(value < 100)
                {
                    points = value;
                }
                else
                {
                    return;
                }
            }
        }

        public bool selected;

        public Skill()
        {

        }
    }
}
