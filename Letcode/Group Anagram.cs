using System;
namespace GroupAnagram{
	public class Program{
		public static void Main(string[] args){
			
			string[] strs = {"eat","tea","tan","ate","nat","bat"};
			List<List<string>> result = GroupAnagram_LetcodeProblem49(strs);
			
			foreach(List<List<string>> item in result){
				Console.Write(string.join(",", item))
			}
			
			Console.ReadLine();
		}
		
		static List<string> GroupAnagram_LetcodeProblem49(string[] values){
			Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
			List<List<string>> result = new List<List<string>>();
			
			for(int i =0; i < values.Length; i++){
				
				char[] sortedString = values[i].ToCharArray();
				Array.Sort(sortedString);
				string key = new string(sortedString);
				
				if(map.ContainsKey(key)){
					map[key].Add(values[i]);
				}else{
					map.Add(s, new List<string>{values[i]});
					result.Add(map[sortedString]);
				}
			}
			
			/*another way to get result from dictionary*/
			/*
			foreach(List<string> list in map.Values){
				result.Add(list);
			}
			*/
			
			return result;
		}
	}
}