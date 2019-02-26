using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secret Number");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("type lucky number");
            Random engine = new Random();
            int secretNumber = engine.Next(100) + 1;
            

            
            //int m = secretNumber;

            //   (new Random !== secretNumber);
            while (g != secretNumber)
            {
                if (secretNumber > g)
                {
                    Console.WriteLine("too big");
                }

                if (secretNumber < g)
                {
                    Console.WriteLine("too small");
                }

                g = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Bingo");
       // תא זכרון שקולט כמה פעמים אני מנחשת
            
               
           
        }


        }
    }
