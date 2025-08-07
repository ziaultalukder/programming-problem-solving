using System;
namespace PrimeNumber{
	
	public class Program{
		
		public static void Main(string[] args){
			
			Console.WriteLine("Enter a Number");
			int number = int.Parse(Console.ReadLine());
			
			if(IsPrime(number)){
				Console.WriteLine( number + " : Number is prime");
			}else{
				Console.WriteLine( number + " : Number is not prime");
			}
			
			Console.ReadLine();
		}
		
		static bool IsPrime(int number){
			
			for(int i = 2; i < number / 2; i++){
				
				if(number % i == 0){
					return false;
				}
			}
			return true;
		}
	}
}