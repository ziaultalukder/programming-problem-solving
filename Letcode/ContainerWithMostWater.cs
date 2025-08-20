using System;
namespace ContainerWithMostWater;
public class Program{
	
	public static void Main(string[] args){
		

		int[] numbers = new int[] {1,8,6,2,5,4,8,3,7};

		int left = 0;
		int right = numbers.Length - 1;
		int maxArea = 0;
				
		while (left < right){
			
			int width = right - left;
			int minHeight = Math.Min(numbers[left], numbers[right]);
			int area = width * minHeight;
			maxArea = Math.Max(area, maxArea);
			
			if(numbers[left] < numbers[right]){
				left++;
			}else if (numbers[left] > numbers[right]){
				right--;
			}else{
				left++;
				right--;
			}
		}
		
		Console.ReadLine();
	}
}