﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GeomatryProblems
{
    internal class Uc2 : Test
    {
		public override void Length()
		{
			Console.WriteLine("X line length is " + xLength);
			Console.WriteLine("Y line length is " + yLength);
			if (xLength == yLength)
				Console.WriteLine("Two lines are equal");
			else
				Console.WriteLine("Two lines are not equal");
		}
	}
}
