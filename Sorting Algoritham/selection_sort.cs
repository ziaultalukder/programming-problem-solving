using System;

namespace Selection_Sort{

	public class Program{

		public static void Main(string[] args){
			int[] arr = {91, 8, 1, 6};
			int[] res = SelectionSort(arr);
			Console.WriteLine(string.Join(",", res));
			Console.ReadLine();
		}
		
		public static int[] SelectionSort(int[] arr){
			for(int i=0; i < arr.Length-1; i++){
		
				int min_index = arr[i];
				
				for(int j = 0; j < arr.Length-1; j++){
					
					if(arr[j] > arr[j+1]){
						min_index = j+1;
					}
				}
				
				int temp = arr[i];
				arr[i] = arr[min_index];
				arr[min_index] = temp;
			}
			return arr;
		}
	}
}