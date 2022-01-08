using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GeomatryProblems
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(" ====== UC-1 output ======\n");
            Test obj;
            obj = new Uc1();
            Console.WriteLine(" ====== UC-1 output ======\n");
            obj.Length();

            Console.WriteLine(" ====== UC-2 output ======\n");
            obj = new Uc2();
            obj.Length();

            Console.WriteLine(" ====== UC-3 output ======\n");
            obj = new Uc3();
            obj.Length();
        }
    }
}