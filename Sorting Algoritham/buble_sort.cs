using System;

namespace Bubble_Sort{

	public class Program{

		public static void Main(string[] args){
			int[] arr = {91, 8, 1, 6};
			int[] res = BubbleSort(arr);
			Console.WriteLine(string.Join(",", res));
			Console.ReadLine();
		}
		
		public static int[] BubbleSort(int[] arr){
			
			for(int i=0; i < arr.Length-1; i++){
				
				for(int j = 0; j < arr.Length-1; j++){
					
					if(arr[j] > arr[j+1]){
						
						int temp = arr[j];
						arr[j] = arr[j+1];
						arr[j+1] = temp;
					}
				}
			}
			return arr;
		}
	}
}