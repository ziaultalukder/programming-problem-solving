using System;
namespace ReverseStringOptimalSolution{
	
	public class Program{
		
		public static void Main(string[] args){
			
			string name = "hello";
			char[] charArray = name.ToCharArray();
			int j = charArray.Length-1;
			
			int count = 0;
			for(int i = 0; i < charArray.Length && i < j; i++,j--){
				
				char h = charArray[i];
				charArray[i] = charArray[j];
				charArray[j] = h;
				count++;
			}
			
			
			Console.WriteLine("Total Count:"+count);
			Console.WriteLine(string.Join(",",charArray));
			Console.ReadLine();
		}
	}
}