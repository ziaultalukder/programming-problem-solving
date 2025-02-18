using System;
namespace FactorialNumber{
	public class Program{
		public static void Main(string[] args){
			int number = 5;
			int result = FactorialNo(number);
			Console.WriteLine(result);
			Console.ReadLine();
		}
		
		static int FactorialNo(int n){
			if(n <= 1)
				return n;
			
			return n * FactorialNo(n-1);
		}
	}
}