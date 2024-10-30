using System;
namespace CountDuplicateInArray{
	
	public class Program{
		
		public static void Main(string[] args){
			
			int[] array = {1, 5, 6, 8, 3};
			
			/*using hasset: hashset remvoe duplicate value*/
			HashSet<int> set = new HashSet<int> (array);
			if(set.count < array.Length) {
				Console.WriteLine(true);
			}else{
				Console.WriteLine(true);
			}
			
			/*using bruit force method*/
		}
		
		static bool CheckDuplicate(int[] numbers){
			for(int i = 0; i < numbers.Length; i++){
				
				for(int j = i+1; j < numbers.Length; j++){
					
					if(array[i] == array[j]){
						
						return true;
					}
				}
			}
			return false;
		}
	}
}