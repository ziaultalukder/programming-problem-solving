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