using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercice1
{   
    public class Program
    {
        public static bool EstPremier(int prem)
        {
            if(prem < 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < prem; i++)
                {
                    if(prem % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }


        }
        static void Main(string[] args)
        {


            int prem = 0;
            do
            {
                Console.WriteLine("entrez un nombre");

            } while (!int.TryParse(Console.ReadLine(), out prem));
 
            if (EstPremier(prem))
            {
                Console.WriteLine("est premier");
            }
            else
            {
                Console.WriteLine("Pas premier");
            }


            

            
        }
    }
}