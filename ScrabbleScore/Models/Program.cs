using System.Collections.Generic;
using System;
using ScrabbleScore.Models;
using System.Linq;

namespace ScrabbleScore.Models 
{
	public class Program
	{
		public static void Main()
		{
			Dictionary<char, int> letterScores = new Dictionary<char, int>() { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, 
		{'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
		{'D', 2}, {'G', 2},
		{'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
		{'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
		{'K', 5},
		{'J', 8}, {'X', 8},
		{'Q',10}, {'Z',10}, };

			Console.WriteLine("Enter a word:");
			string userInput = Console.ReadLine();
			int count = 0;
			int userInputLength = userInput.Length;
			string word = userInput.ToUpper();


			for (int i = 0; i < userInputLength; i ++)
				{
					foreach(KeyValuePair<char, int> kvp in letterScores)
					{
						Console.WriteLine(kvp.Key);
						if (kvp.Key == (word[i]))
						{
							count += kvp.Value;
							break;
						}
					}
				}
				Console.WriteLine(count);
						// foreach (char letter in letterArray)
			// {
			// 	if (letter == letterScores{0})
			// 	{
			// 		count = count + letterScores{1};
			// 	}
			// }	

			//.Where((letter) => letters.ContainsKey(letter))
			// //or	
		}
	}
}