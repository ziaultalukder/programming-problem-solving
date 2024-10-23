using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProblemNo_05_CheckIfIsAvailableOrNot("if else "));
            Console.ReadLine();
        }
        
		static string ProblemNo_05_CheckIfIsAvailableOrNot(string givenString)
		{
			/*this solution from solution provider*/
			if(givenString.Length > 2 && givenString.Substring(0, 2).Equals("if"))
			{
				return givenString;
			}
			else
			{
				return "if " + givenString;
			}

			/*this solution from me*/
			string[] d = givenString.Split();
			
			if (d[0] == "if")
			{
				return givenString;
			}
			else
			{
				return "if " + givenString;
			}
		}
    }
}