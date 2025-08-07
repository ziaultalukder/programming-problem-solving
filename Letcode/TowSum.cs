using System;
namespace TowSum{
	
	public class Program{
		
		public static void Main(string[] args){
			int[] number = { 10, 20, 35, 50 };
			int target = 70;
			
			
			Console.WriteLine(string.Join(",", TwoPointer(number, target)));
			//Console.WriteLine(SumTowNumber(number, target));
			Console.ReadLine();
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
		
		static int[] TwoPointer(int[] number, int target){
			
			int left = 0; 
			int right = number.Length -1;
			int count = 0;
			while(count < number.Length){
				
				if(number[left] + number[right] == target){
					return new int[] {number[left], number[right]};
				}
				
				if(number[left] + number[right] < target){
					left++;
				}else{
					right--;
				}
				
				count++;
			}
			return new int[] {};
		}
	}
}