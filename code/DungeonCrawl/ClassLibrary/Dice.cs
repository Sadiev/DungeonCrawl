using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dice
    {
        private int _numOfDice;
        private int _sizeOfDice;
        Random rnd = new Random();

        public int NumOfDice { get { return _numOfDice; } set { _numOfDice = value; } }
        public int SizeOfDice { get { return _sizeOfDice; } set { _sizeOfDice = value; } }
        
        public Dice(string dice)
        {
            string[] tokens = dice.Split('d');
            int numOfDice = int.Parse(tokens[0]);
            int sizeOfDice = int.Parse(tokens[1]);
            NumOfDice = numOfDice;
            SizeOfDice = sizeOfDice;
        }

        public Dice(int Num, int Size)
        {
            NumOfDice = Num;
            SizeOfDice = Size;
        }

        public int Roll()
        {
            int sum = 0;

            for (int i = 0; i < _numOfDice; i++)
            {
                sum += rnd.Next(_sizeOfDice + 1);
            }
            return sum;
        }
    }
}
