using System.Collections.Generic;
using System;
using ScrabbleScore.Models;

namespace ScrabbleScore.Models 
{
	public class Program
	{
		public static void Main()
		{
			Dictionary<char, int> letterScores = new Dictionary<char, int>() { {'a',1 }, {'e', 1} , {'i',1 } };
			Console.WriteLine("Enter a word:");
			string userInput = Console.ReadLine();
			int count = 0;
			int userInputLength = userInput.Length;
			char[] letterArray = userInput.ToCharArray(0, userInputLength);
			
			foreach (char letter in letterArray)
			{
				if (letter == letterScores{0})
				{
					count = count + letterScores{1};
				}
			}	
			// //or
			// for (int i = 0; i <= userInputLength; i ++)
			// 	{
			// 		if (letterScores.ContainsKey("a"))
			// 		{
			// 			count ++;
			// 			//letterScores{0}
			// 		}
			// 		else{}
			// 	}
			
			Console.WriteLine(count);
		}
	}
}