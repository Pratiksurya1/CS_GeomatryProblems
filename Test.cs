using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GeomatryProblems
{
    public abstract class Test
    {
        public static int xLength=0, yLength=0;
         static Test()
       // static
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter X1 value :-");
            x1 =Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter X2 value :-");
            x2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y1 value :-");
            y1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y2 value :-");
            y2 = Int32.Parse(Console.ReadLine());

            xLength = (x1 - x2) * (x1 - x2);
            yLength = (y1 - y2) * (y1 - y2);

        }
        public abstract void Length();
    }
}
