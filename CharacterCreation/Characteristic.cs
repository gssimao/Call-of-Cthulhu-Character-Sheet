using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Characteristic : Character
    {
        int charSTR;
        int charDEX;
        int charPOW;
        int charCON;
        int charAPP;
        int charEDU;
        int charSIZ;
        int charINT;
        int charMoveRate;

        public int CharSTR
        {
            get
            {
                return charSTR;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charSTR = SetCharacteristic(false) ;
                }
                else
                {
                    charSTR = value;
                }

            }
        }
        public int CharDEX
        {
            get
            {
                return charDEX;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charDEX = SetCharacteristic(false);
                }
                else
                {
                    charDEX = value;
                }

            }
        }
        public int CharPOW
        {
            get
            {
                return charPOW;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charPOW = SetCharacteristic(false);
                }
                else
                {
                    charPOW = value;
                }

            }
        }
        public int CharCON
        {
            get
            {
                return charCON;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charCON = SetCharacteristic(false);
                }
                else
                {
                    charCON = value;
                }

            }
        }
        public int CharAPP
        {
            get
            {
                return charAPP;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charAPP = SetCharacteristic(false);
                }
                else
                {
                    charAPP = value;
                }

            }
        }
        public int CharEDU
        {
            get
            {
                return charEDU;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charEDU = SetCharacteristic(true);
                }
                else
                {
                    charEDU = value;
                }

            }
        }
        public int CharSIZ
        {
            get
            {
                return charSIZ;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charSIZ = SetCharacteristic(true);
                }
                else
                {
                    charSIZ = value;
                }

            }
        }
        public int CharINT
        {
            get
            {
                return charINT;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charINT = SetCharacteristic(true);
                }
                else
                {
                    charINT = value;
                }

            }
        }
        public int CharMoveRate
        {
            get
            {
                return charMoveRate;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    //charMoveRate = SetCharacteristic();
                }
                else
                {
                    charMoveRate = value;
                }

            }
        }

        public static readonly Random DiceRandom = new Random();
        public int RollingDices(int max)
        {
            int roll;
            roll = DiceRandom.Next(1, max);
            return roll;
        }
        public Characteristic (bool Randomize)
        {

        }

        int SetCharacteristic(bool GiveLastDie)
        {
            int RollResult = 0;
            int Loop = 0;

            if(!GiveLastDie)
            {
                RollResult += 6;
                Loop += 1;   
            }
            while(Loop > 3)
            {
                Loop++;
               // RollResult += DiceRoll.RollingDices(7);
            }
            RollResult *= 5;
            return RollResult;
        }

    }
}
