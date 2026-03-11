using System;
using System.Collections.Generic;
using System.Text;

namespace ScoringSystem
{
    internal class studentMarks
    {
        public void CheckMarks(int X, int Y, int N1, int N2, int M)
        {
			int xQuestions = 0;
			int yQuestions = 0;

			for (int y = 1; y <= N2; y++)
			{
				for (int x = 1; x <= N1; x++)
				{
					if (X * x + Y * y == M)
					{
						xQuestions = x;
						yQuestions = y;
						break;
					}
				}
			}

			if (xQuestions != 0 && yQuestions != 0)
			{
				Console.WriteLine("Valid");
				Console.WriteLine(xQuestions);
				Console.WriteLine(yQuestions);
			}
			else
			{
				Console.WriteLine("Invalid");
			}
		}
    }
}
