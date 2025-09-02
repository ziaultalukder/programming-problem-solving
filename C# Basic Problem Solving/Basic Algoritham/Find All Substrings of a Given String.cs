using System;
namespace FindSubStringOfaGivenStrinh{
	public class Program{
		public static void Main(string[] args){
			
		}
		
		static string GetAllSubString(string value){
			
			/*my way*/
			string result = string.Empty;
			int count = 0;
			for(int i = 0; i < value.Length; i++){
				result += value.Substring(0, i+1);
				value.Substring(count);
				for(int j =0; i<value.Length; i++){
					result += value.Substring(0, j+1);
				}
			}
			
			/*another way*/
			for(int i=0; i < value.Length; i++){
				string d = value[i];
				Console.WriteLine(d);
				for(int j=i+1; j < value.Length; j++){
					d = string.Concat(d, "", value[j]);
					Console.WriteLine(d);
				}
			}
			
			/*way from youtube*/
			for(int i =0; i < value.Length; i++){
				for(int j = 0; i<value.Length -i; i++){
					result += value.Substring(i, j+1);
				}
			}
			
			return result;
		}
	}
}