using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GeomatryProblems
{
    public class Uc1 : Test
    {
		public override void Length()
		{
			double length = xLength + yLength;
			Console.WriteLine("X and Y lien length is :- " + length);
		}
	}
}
