using System;
namespace EvenAndOddNumber{
	
	public class Program{
		
		public static void Main(string[] args){
			
			int[] array = new int[] {1, 5, 6, 8, 3};
			
			for(int i = 0; i < array.Length; i++){
				
				if(array[i] % 2 == 0){
					
					Console.WriteLine("even number :"+ array[i]);
				}else{
					Console.WriteLine("odd number :"+ array[i]);
				}
			}
		}
	}
}