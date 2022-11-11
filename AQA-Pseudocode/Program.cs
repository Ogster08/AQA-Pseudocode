using System;

namespace AQA_Pseudocode
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] codeArray = System.IO.File.ReadAllLines("Pseudocode.txt");
			string code = string.Join(Environment.NewLine, codeArray);

			Tokeniser tokeniser = new Tokeniser(code);
			List<Token> tokens = tokeniser.GetTokens();
		}
	}
}