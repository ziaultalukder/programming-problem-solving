using System;
namespace PalindromNumber{
	
	public class Porgram{
		
		public static void Main(string[] args){
			
			Console.WriteLine("input a number");
			int number = int.Parse(Console.ReadLine());
			int originalNumber = number;
			int sum = 0;
			
			while(number > 0){
				
				int reminder = number % 10;
				sum = (sum*10)+reminder;
				number = number /10;
			}
			
			if(sum == originalNumber){
				Console.WriteLine("palindrom a number");
			}else{
				Console.WriteLine("palindrom not number");
			}
			
			Console.ReadLine();
		}
	}
}