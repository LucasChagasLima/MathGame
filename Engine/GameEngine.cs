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
            int result = this.NumRandom1 - this.NumRandom2;
            return result;
        }

        public int Multiplication()
        {
            int result = this.NumRandom1 * this.NumRandom2;
            return result;
        }

        public int Division()
        {
            int divisor = this.NumRandom1;
            int result = this.NumRandom2;

            int final = divisor * result;

            return final;
            
        }



    }
}