using System;
namespace fibonacci{
	public class Program{
		
		public static void Main(string[] args){
			int a = 0;
			int b = 1;
			
			for(int i = 0; i < 10; i++){
				int res = a+b;
				Console.Write(res+",");
				a=b;
				b=res;
			}
			Console.ReadLine();
		}
	}
}