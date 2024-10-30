using System;
namespace EvenAndOddNumber{
	
	public class Program{
		
		public static void Main(string[] args){
			int[] number = { 10, 20, 35, 50 };
			int target = 70;
			Console.WriteLine(SumTowNumber(number, target));
		}
		
		static int[] SumTowNumber(int[] numbers, int target)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = i + 1; j < numbers.Length; j++)
				{
					if (numbers[i] + numbers[j] == target)
					{
						return new int[] {i, j};
					}
				}
			}
			return new int[] {};
		}
	}
}