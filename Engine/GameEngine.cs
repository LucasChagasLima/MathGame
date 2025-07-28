using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MathGame.Engine
{
    public class GameEngine
    {
        public int NumRandom1 { get; set; }
        public int NumRandom2 { get; set; }
        public int UserAnswer { get; set; }
        Random random = new Random();




        public int RandomNumberGenerator()
        {
            int number = random.Next(1, 101);
            return number;

        }

        public GameEngine()
        {
            NumRandom1 = RandomNumberGenerator();
            NumRandom2 = RandomNumberGenerator();
        }

        public int Sun()
        {
            int result = this.NumRandom1 + this.NumRandom2;
            return result;
        }

        public int Subtraction()
        {
            int num3;
            if (this.NumRandom1 < this.NumRandom2)
            {
                num3 = this.NumRandom1;
                this.NumRandom1 = this.NumRandom2;
                this.NumRandom2 = num3;

                int result = this.NumRandom1 - this.NumRandom2;
                return result;

            }
            else
            {
                int result = this.NumRandom1 - this.NumRandom2;
                return result;
            }
        }

        public int Multiplication()
        {
            int result = this.NumRandom1 * this.NumRandom2;
            return result;
        }

        public void GenerateValidDivisionNumbers()
        {
            int num1, num2;
            do
            {
                num1 = RandomNumberGenerator();
                num2 = RandomNumberGenerator();
                if (num1 < num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
            } while (num2 == 0 || num1 % num2 != 0);
            this.NumRandom1 = num1;
            this.NumRandom2 = num2;
        }

        public int Division()
        {
            return this.NumRandom1 / this.NumRandom2;
        }



    }
}