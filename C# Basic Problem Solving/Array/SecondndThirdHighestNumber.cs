using System;
namespace SecondndThirdHighestNumber{
	
	public class Program{
		
		public static void Main(string[] args){
			int[] numbers = {19,45,16,25};
			int MaxNo = numbers.Max();
			int SecondHighest = 0;
			int ThirdHighest = 0;
			
			for(int i=0; i < numbers.Length; i++){
				
				/*second highest number*/
				if(numbers[i] < MaxNo && numbers[i] > SecondHighest){
					SecondHighest = numbers[i];
				}
				
				/*third highest number*/
				if(numbers[i] < SecondHighest && numbers[i] > ThirdHighest){
					ThirdHighest = numbers[i];
				}
			}
			
			Console.WriteLine("Max No : " + maxNo + " and Second Max No : " + secondHighest + " and Third Max No : " + thirdHighest);
		}
	}
}