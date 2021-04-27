using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Characteristic : Character
    {
        public string Contacts;
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
                if (value == 0)
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
        public  string _occupationName;
        public string OccupationName
        {
            get
            {
                return _occupationName;
            }

            set
            {
                _occupationName = value;
            }

        }

        public string _suggestedSkills;
        public string SuggestedSkills
        {
            get
            {
                return _suggestedSkills;
            }

            set
            {
                _suggestedSkills = value;
            }

        }
        public int _skillpointsAvailable;
        public int SkillpointsAvailable
        {
            get
            {
                return _skillpointsAvailable;
            }

            set
            {
                _skillpointsAvailable = value;
            }

        }

        public int SetCharacteristic(bool GiveLastDie)
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
        
        public int HighNum(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        public int calculateSkillPointsAvailable(string OccupationName, int STR, int DEX, int POW, int CON, int APP, int EDU, int SIZ, int INT)
        {
            string name = OccupationName;
            OccupationName = name.ToLower();
            switch (OccupationName)
            {
                case "accountant":
                    return EDU * 4;

                case "acrobat":
                    return (EDU * 2)+ (DEX * 2);

                case "actor":
                    return (EDU * 2) + (APP * 2);

                case "film star":
                    return (EDU * 2) + (APP * 2);

                case "agency detective":
                    return (EDU * 2) + (HighNum(STR, DEX) * 2);

                case "alienist":
                    return EDU * 4;

                case "animal trainer":
                    return (EDU * 2) + (HighNum(APP, POW) * 2);

                case "atiquarian":
                    return EDU * 4;

                case "antique dealer":
                    return EDU * 4; 

                case "archaeologist":
                    return EDU * 4; 

                case "architect":
                    return EDU * 4; 

                case "artist":
                    return (EDU * 2) + (HighNum(DEX, POW) * 2);

                case "asylum attendant":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);
                     
                case "assassin":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "author":
                    return EDU * 4;

                case "aviator":
                    return EDU * 4;

                case "bank robber":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "bartender":
                    return (EDU * 2) + (APP * 2);

                case "big game hunter":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "book dealer":
                    return EDU * 4;

                case "bootlegger":
                    return (EDU * 2) + (STR * 2);

                case "bounty hunter":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "boxer/wrestler":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "boxer":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "wrestler":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "burglar":
                    return (EDU * 2) + (DEX * 2);

                case "butler":
                    return EDU * 4;

                case "valet":
                    return EDU * 4;

                case "maid":
                    return EDU * 4;

                case "chauffeur":
                    return (EDU * 2) + (DEX * 2);

                case "computer programmer":
                    return EDU * 4;

                case "hacker":
                    return EDU * 4;

                case "computer programmer/hacker":
                    return EDU * 4;

                case "conman":
                    return (EDU * 2) + (APP * 2);

                case "cowboy":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "cowgirl":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "cowboy/girl":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "craftsperson":
                    return (EDU * 2) + (DEX * 2);

                case "criminal":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "cult leader":
                    return EDU * 4;

                case "deprogrammer":
                    return EDU * 4;

                case "designer":
                    return EDU * 4;

                case "dilletante":
                    return (EDU * 2) + (APP * 2);

                case "diver":
                    return (EDU * 2) + (DEX * 2);

                case "doctor of medicine":
                    return EDU * 4;

                case "drifter":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "driver":
                    return (EDU * 2) + (DEX * 2);

                case "editor":
                    return EDU * 4;

                case "elected official":
                    return (EDU * 2) + (APP * 2);

                case "enginner":
                    return EDU * 4;

                case "entertainer":
                    return (EDU * 2) + (APP * 2);

                case "explorer":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "farmer":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "federal agent":
                    return EDU * 4;

                case "fence":
                    return EDU * 4;

                case "firefighter":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "foreign correspondent":
                    return EDU * 4;

                case "forensic surgeon":
                    return EDU * 4;

                case "forger/counterfeiter":
                    return EDU * 4;

                case "counterfeiter":
                    return EDU * 4;

                case "forger":
                    return(EDU * 2) + (HighNum(DEX, STR) * 2);

                case "gambler":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "gangster":
                    return (EDU * 2) + (APP * 2);

                case "gun Moll":
                    return EDU * 4;

                case "gentleman/lady":
                    return (EDU * 2) + (APP * 2);

                case "gentleman":
                    return (EDU * 2) + (APP * 2);

                case "lady":
                    return (EDU * 2) + (APP * 2);

                case "hobo":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "hospital Orderly":
                    return (EDU * 2) + (STR * 2);

                case "journalist":
                    return EDU * 4;

                case "judge":
                    return EDU * 4;

                case "laboratory assistant":
                    return EDU * 4;

                case "laborer":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "lawyer":
                    return EDU * 4;

                case "librarian":
                    return EDU * 4;

                case "lumberjack":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "mechanic":
                    return EDU * 4;

                case "military Officer":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "miner":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "missionary":
                    return (EDU * 2) + (APP * 2);

                case "mountain climber":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "museum curator":
                    return EDU * 4;

                case "musician":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "nurse":
                    return EDU * 4;

                case "occutist":
                    return EDU * 4;

                case "outdoorsman/outdoorswoman":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "outdoorsman":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "outdoorswoman":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "parapsychologist":
                    return EDU * 4;

                case "pharmacist":
                    return EDU * 4;

                case "photographer":
                    return EDU * 4;

                case "photojournalist":
                    return EDU * 4;

                case "Pilot":
                    return (EDU * 2) + (DEX * 2);

                case "police detective/officer":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "police detective":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "officer":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "private investigator":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "professor":
                    return EDU * 4;

                case "prostitute":
                    return (EDU * 2) + (APP * 2);

                case "psychiatrist":
                    return EDU * 4;

                case "psychologist/psychoanalyst":
                    return EDU * 4;

                case "psychologist":
                    return EDU * 4;

                case "psychoanalyst":
                    return EDU * 4;

                case "reporter":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "researcher":
                    return EDU * 4;

                case "sailor":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "salesperson":
                    return (EDU * 2) + (APP * 2);

                case "secretary":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "shopkeeper":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "smuggler":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "soldier/marine":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "soldier":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "marine":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "spy":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "street punk":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "student/intern":
                    return EDU * 4;

                case "student":
                    return EDU * 4;

                case "intern":
                    return EDU * 4;

                case "stuntman":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "taxi driver":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "thug":
                    return (EDU * 2) + (HighNum(DEX, STR) * 2);

                case "tribe member":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "undertaker":
                    return EDU * 4;

                case "union activist":
                    return EDU * 4;

                case "waitress/waiter":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "waiter":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "waitress":
                    return (EDU * 2) + (HighNum(DEX, APP) * 2);

                case "white-collar worker":
                    return EDU * 4;

                case "zealot":
                    return (EDU * 2) + (HighNum(POW, APP) * 2);

                case "zookeeper":
                    return EDU * 4;

                default:
                    Console.WriteLine("The input does not match none of the occupations");
                    break;
            }
            
            return 0;
        }
    }
}
