using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreation
{
    public partial class RollDice : Form
    {
        public int[] DiceRoll = new int[] {0,0,0,0,0,0};
        //D4 is in DiceRoll[0]
        //D6 is in DiceRoll[1]
        //D8 is in DiceRoll[2]
        //D10 is in DiceRoll[3]
        //D20 is in DiceRoll[4]
        //D100 is in DiceRoll[5]*/
        public int Mod = 0;
        public static readonly Random DiceRandom = new Random();

        public RollDice()
        {
            InitializeComponent();
        }


        private void Roll_Click(object sender, EventArgs e)
        {
            RollResult.Clear();
            int total = 0;
            int mod = 0;
            
            if(int.TryParse(Modifier.Text, out mod))
            {}
            if (D4.Value != 0)
            {
                total += MultipleRollsCalculation(D4.Value, 5);
            }
            if (D6.Value != 0)
            {
                total += MultipleRollsCalculation(D6.Value, 7);
            }
            if (D8.Value != 0)
            {
                total += MultipleRollsCalculation(D8.Value, 9);
            }
            if (D10.Value != 0)
            {
                total += MultipleRollsCalculation(D10.Value, 11);
            }
            if (D20.Value != 0)
            {
                total += MultipleRollsCalculation(D20.Value, 21);
            }
            if (D100.Value != 0)
            {
                total += MultipleRollsCalculation(D100.Value, 101);
            }

            total += mod;
            if(mod != 0)
            {
                 RollResult.Text += "+ mod." + mod.ToString() + " ";
            }
               

            RollResult.Text += "Total is " + total.ToString();

        }

        int RollingDices(int max)
        {
            int roll;
            roll = DiceRandom.Next(1, max);
            RollResult.Text += roll.ToString() + " ";
            return roll;
        }

        int MultipleRollsCalculation(decimal rolls, int dice)
        {
            int total = 0;
            for(int i = 0; i < rolls; i++)
            {
                total += RollingDices(dice);
                
            }
            return total;
        }

        private void RollDice_Load(object sender, EventArgs e)
        {

        }

    }
}
