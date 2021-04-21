using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Characteristic : Character
    {
        public int charSTR;
        public int charDEX;
        public int charPOW;
        public int charCON;
        public int charAPP;
        public int charEDU;
        public int charSIZ;
        public int charINT;
        public int charLuck;
        public int charMoveRate;
        public int charHP;
        public int charMP;
        public int charAge;
        public int CharAge
        {
            get
            {
                return charAge;
            }
            set
            {
                if (value == 0 && RandomizeChar == true)
                {
                    charAge = RollingDices(61) + 14;
                }
                else
                {
                    charAge = value;
                }

            }
        }
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
        public int CharLuck
        {
            get
            {
                return charLuck;
            }
            set
            {
                if (RandomizeChar == true)
                {
                    charLuck = SetCharacteristic(true);
                }
                else
                {
                    charLuck = value;
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
                    charMoveRate = CalculateMoveRate(CharSTR, CharDEX, CharSIZ);
                }
                else
                {
                    charMoveRate = value;
                }

            }
        }
        public int CharHP
        {
            get
            {
                return charHP;
            }
            set
            {
                charHP = CalculateHP(CharSIZ, CharCON);
            }
        }
        public int CharMP
        {
            get
            {
                return charMP;
            }
            set
            {
                charMP = CalculateMagicPoint(CharPOW);
            }
        }

       /* public Characteristic(int STR, int DEX, int POW, int CON, int APP, int EDU, int SIZ, int INT, int LUCK, int MoveRate)
        {
            CharSTR = STR;
            CharDEX = DEX;
            CharPOW = POW;
            CharCON = CON;
            CharAPP = APP;
            CharEDU = EDU;
            CharSIZ = SIZ;
            CharINT = INT;
            CharLuck = LUCK;
            CharMoveRate = MoveRate;
        }
        public Characteristic(bool randomize)
        {
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
        }*/

        int SetCharacteristic(bool GiveLastDie)
        {
            int RollResult = 0;
            int Loop = 0;

            if(!GiveLastDie)
            {
                RollResult += 6;
                Loop += 1;   
            }
            while(Loop < 3)
            {
               Loop++;
               RollResult += this.RollingDices(7);
            }
            RollResult *= 5;
            return RollResult;
        }

        public int CalculateMagicPoint(int POW)
        {
            int calc = (int)Math.Floor((float)POW / 5);
            return calc;
        }
        public string CalculateDamageBonus(int STR, int SIZ)
        {
            int combine = STR + SIZ;
            if (combine <= 64)
            {
                return "-2";
            }
            else if (combine >= 65 && combine <= 84)
            {
                return "-1";
            }
            else if (combine >= 85 && combine <= 124)
            {
                return "None";
            }
            else if (combine >= 125 && combine <= 164)
            {
                return "+1D4";
            }
            else if (combine >= 165)
            {
                return "+1D6";
            }
            return "";
        }
        public string CalculateBuild(int STR, int SIZ)
        {
            int combine = STR + SIZ;
            if (combine <= 64)
            {
                return "-2";
            }
            else if (combine >= 65 && combine <= 84)
            {
                return "-1";
            }
            else if (combine >= 85 && combine <= 124)
            {
                return "None";
            }
            else if (combine >= 125 && combine <= 164)
            {
                return "+1";
            }
            else if (combine >= 165)
            {
                return "+2";
            }
            return "";
        }
        public int CalculateHP(int SIZ, int CON)
        {
            int calc = (int)Math.Floor(((float)SIZ + CON) / 10);
            return calc;
        }
        public int CalculateMoveRate(int STR, int DEX, int SIZ)
        {
            int mov = 0;
            if (CharAge > 40)
            {
                mov = -1;
            }
            if (STR < SIZ && STR < SIZ)
            {
                mov += 7;
            }
            else if (STR >= SIZ || DEX >= SIZ)
            {
                mov += 8;
            }
            else if (STR > SIZ && DEX > SIZ)
            {
                mov += 9;
            }
            return mov;
        }
    }
}
