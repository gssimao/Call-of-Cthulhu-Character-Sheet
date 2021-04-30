﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Gentleman : Characteristic
    {
        public readonly string _occupationTitle = "Gentleman";

        public readonly string _creditRating = "40 - 90";
        public string _suggestedContacts = "Upper classes and landed gentry, politics, servants and agricultural workers.";
        public string OccupationSkills = "Art/Craft (any), two interpersonal skills (Charm, Fast Talk, Intimidate, or Persuade), Firearms(Rifle/ Shotgun), History, Other Language(any), Navigate, Ride.";
        public int SelectMoreSkills = 0; 
        public Gentleman()
        {
            SkillpointsAvailable = calculateSkillPointsAvailable(this.OccupationName ,this.charSTR, this.charDEX, this.charPOW, this.charCON, this.charAPP, this.charEDU, this.charSIZ, this.charINT);
        }
        public Gentleman(bool random) // this is a random accountant
        {
            CharAge = 0;
            creditRating = _creditRating;
            _occupationName = _occupationTitle;
            _suggestedSkills = OccupationSkills;
            Contacts = _suggestedContacts;
            CharSex = RollingDices(3);// 1 = male /// 2 = female;
            CharBirthplace = SelectBirthPlace();
            //base character randomization
            CharName = SelectName();
            CharResidence = SelectResidence();

            //characteristic randomization
            RandomizeChar = random;
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

            //occupation point skill calculation
            SkillpointsAvailable = calculateSkillPointsAvailable(_occupationName, CharSTR, CharDEX, CharPOW, CharCON, CharAPP, CharEDU, CharSIZ, CharINT);
        }

    }
}