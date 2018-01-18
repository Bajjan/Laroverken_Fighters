using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops_Csharpskolan
{
    using System;

    class Program
    {
        static void Main()
        {
            //Övning 1
            //for (int i = 0; i < 101; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //Övning 2
            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Övning 3
            for (int i = 0; i < 52; i = i+2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
