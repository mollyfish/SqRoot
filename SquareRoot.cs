using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part1
{
    class SquareRoot
    {

        public double N;
        public double G;
        public double E;
        public double result;

        public SquareRoot(double N, double E, double guess)
        {
            this.N = N;
            this.G = guess;
            this.E = E;
            this.result = Math.Sqrt(N);
        }

        public double Heron() { 
                if (this.G <= 0)
                {
                    Console.WriteLine("ABORT: Guesses must be positive.");
                    throw new Exception("Guesses must be positive.");
                } else
                {
                double Nmin = N * (1 - this.E);
                double Nmax = N * (1 + this.E);
                if (G * G == N)
                {
                    //Console.WriteLine("Got it! " + this.G + " is the square root of " + N);
                    //Console.WriteLine("G: " + this.G);
                }
                else {
                    while (!(Nmin < (this.G * this.G) && (this.G * this.G) < Nmax))
                    {
                        //Console.WriteLine("Guess was wrong. Trying again.");
                        this.G = (this.G + N / this.G) / 2;
                    }

                    //Console.WriteLine("G: " + this.G);
                }
                return this.G;
            }
        }
        public double Standard()
        {
            this.result = Math.Sqrt(this.N);
            //Console.WriteLine("result: " + this.result);
            return result;
        }
    }
}
