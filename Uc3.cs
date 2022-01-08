using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GeomatryProblems
{
    internal class Uc3 : Test
    {
		public override void Length()
		{

			Console.WriteLine("X line length is " + xLength);
			Console.WriteLine("Y line length is " + yLength);

			if (xLength == yLength)
				Console.WriteLine("Two lines are equal");
		else if (xLength < yLength)
				Console.WriteLine("Y line is greater than X line");
		else if (yLength < xLength)
				Console.WriteLine("X line is greater than y line");

		}
	}
}
