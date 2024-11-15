using System;
namespace ReverseString{
	public class Program{
		
		public static void Main(string[] args){
			
		}
		
		static string ReverseStringUsingForLoop(string value){
			
			string result = string.Empty;
			for(int i = value.Length - 1; i >=0; i++){
				result += value[i];
			}
			
			return result;
		}
		
		static string ReverseStringUsingForeach(string value){
			string result = string.Empty;
			foreach(char res in value){
				result = res + result;
			}
			return result;
		}
	}
}