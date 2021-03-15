﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    internal class Character
    {
        public static readonly Random DiceRandom = new Random();
        public bool RandomizeChar = false;

        string charName;
        public string CharName
        {
            get
            {
                return charName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && RandomizeChar == true)
                {
                    charName = SelectName();
                }
                else
                {
                    charName = value;
                }
                
            }
        }
        string charPlayer;
        public string CharPlayer
        {
            get
            {
                return charPlayer;
            }
            set
            {
                charPlayer = value;
            }
        }
        string charOccupation;
        public string CharOccupation
        {
            get
            {
                return charOccupation;
            }
            set
            {
                charOccupation = value;
            }
        }
        string charBirthplace;
        public string CharBirthplace
        {
            get
            {
                return charBirthplace;
            }
            set
            {
                charBirthplace = value;
            }
        }
        string charResidence;
        public string CharResidence
        {
            get
            {
                return charResidence;
            }
            set
            {
                charResidence = value;
            }
        }
        int charAge;
        public int CharAge
        {
            get
            {
                return charAge;
            }
            set
            {
                charAge = value;
            }
        }

        public Character(string charName, string charPlayer, string charOccupation, string charBirthplace, string charResidence, int charAge)
        {
            CharName = charName;
            CharPlayer = charPlayer;
            CharOccupation = charOccupation;
            CharBirthplace = charBirthplace;
            CharResidence = charResidence;
            CharAge = charAge;
        }

        public Character(bool randomize) // Create a randomized character
        {
            string empty = "";
            
            RandomizeChar = randomize;
            CharName = empty;
            CharPlayer = empty;
            CharOccupation = empty;
            CharBirthplace = empty;
            CharResidence = empty;
            CharAge = 0;
        }
        int RollingDices(int max)
        {
            int roll;
            roll = DiceRandom.Next(1, max);
            return roll;
        }
        string SelectName()
        {
            string name = "";
            int RandomCharSex = RollingDices(3); // 1 = male /// 2 = female
            if(RandomCharSex == 1)
            {
                string[] MaleNames = new string[] 
                { "",
                    "John",
                    "James",
                    "William",
                    "Charles",
                    "George",
                    "Joseph",
                    "Richard",
                    "Edward",
                    "Donald",
                    "Thomas",
                    "Frank",
                    "Harold",
                    "Paul",
                    "Raymond",
                    "Walter",
                    "Jack",
                    "Henry",
                    "Kenneth",
                    "Arthur",
                    "Albert",
                    "Harry",
                    "Eugene",
                    "Ralph",
                    "Howard",
                    "Willie",
                    "Fred",
                    "Francis",
                    "Herbert",
                    "Alfred",
                    "Norman",
                    "Gerald",
                    "Bernard",
                    "Melvin",
                    "Warren",
                    "Michael",
                    "Russell",
                    "Elmer",
                    "Lloyd",
                    "Vernon",
                    "Clyde",
                    "Chester",
                    "Philip",
                    "Alvin",
                    "Wayne",
                    "Lewis",
                    "Harvey",
                    "Maurice",
                    "David",
                    "Robert"}; // 50 names
                name += MaleNames[RollingDices(51)];
            }
            else if (RandomCharSex == 2)
            {
                string[] FemaleNames = new string[]
                { "",
                    "Helen",
                    "Margaret",
                    "Ruth",
                    "Doris",
                    "France",
                    "Elizabeth",
                    "Anna",
                    "Alice",
                    "Jean",
                    "Barbara",
                    "Marjorie",
                    "Florence",
                    "Martha",
                    "Lillian",
                    "Louise",
                    "Ruby",
                    "Patricia",
                    "Gladys",
                    "Josephine",
                    "Edna",
                    "Norma",
                    "Lucille",
                    "Gloria",
                    "Ethel",
                    "Grace",
                    "June",
                    "Bernice",
                    "Dolores",
                    "Lorraine",
                    "Dorothy",
                    "Betty",
                    "Virgina",
                    "Mildred",
                    "Evelyn",
                    "Marie",
                    "Shirley",
                    "Irene",
                    "Lois",
                    "Rose",
                    "Catherine",
                    "Eleanor",
                    "Annie",
                    "Thelma",
                    "Pauline",
                    "Edith",
                    "Phyllis",
                    "Hazel",
                    "Rit",
                    "Mary"}; // 50 names
                name += FemaleNames[RollingDices(51)];
            }
            string[] Surnames = new string[]
               { "",
                    "Ankins",
                    "Baker",
                    "Belanger",
                    "Bhenki",
                    "Click",
                    "Collins",
                    "Crankovitch",
                    "Darwin",
                    "Dorman",
                    "English",
                    "Fandrick",
                    "Felten",
                    "Finley",
                    "Franklin",
                    "Garvin",
                    "Greenwalt",
                    "Hahn",
                    "Hass",
                    "Heminger",
                    "Hilt",
                    "Kloburcher",
                    "Levard",
                    "Lynch",
                    "McBurney",
                    "McDonald",
                    "Morris",
                    "Nickels",
                    "O'Neil",
                    "Peppin",
                    "Porter",
                    "Price",
                    "Rossini",
                    "Schwarm",
                    "Schwartz",
                    "Simmons",
                    "Shirley",
                    "St. Dennis",
                    "Tenker",
                    "Webber",
                    "Westin",
                    "White",
                    "Winters",
                    "Woods",
                    "Zibart",
                    "Wall",
                    "Walsted",
                    "Yeske",
                    "Strong",
                    "Swanson"}; // 50 names
            name += " " + Surnames[RollingDices(51)];

            return name;
        }
    }
}