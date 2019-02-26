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
            Console.WriteLine("type lucky number");
            Random engine = new Random();
            int secretNumber = engine.Next(100) + 1;
            

            Console.WriteLine("Secret Number");
            int g = Convert.ToInt32(Console.ReadLine());
            //int m = secretNumber;

            //   (new Random !== secretNumber);
            while (g != secretNumber)
            {
                if (secretNumber > g)
                {
                    Console.WriteLine("too big");
                }
                else
                {
                    Console.WriteLine("too small");
                }
            }
       // תא זכרון שקולט כמה פעמים אני מנחשת
            Console.WriteLine("bingo");
               
           
        }


        }
    }
}
