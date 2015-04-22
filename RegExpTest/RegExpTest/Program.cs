using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExpTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputString = "123:her-789";
			var inputString2 = ":her-789";

			Console.WriteLine("Input string: {0}", inputString);
			Console.WriteLine();

			var startFromRegex = new Regex(@"^123");
			Console.WriteLine(@"Regex: {0} - start from
Match: {1}
", startFromRegex.ToString(), startFromRegex.Match(inputString).Value);

			var endWithRegex = new Regex(@"789$");
			Console.WriteLine(@"Regex: {0} - end with
Match: {1}
", endWithRegex.ToString(), endWithRegex.Match(inputString).Value);

			var startEndRegex = new Regex(@"^123:.*-789$");
			Console.WriteLine(@"Regex: {0} - start from & end with
Match: {1}
", startEndRegex.ToString(), startEndRegex.Match(inputString).Value);

			var containsRegex = new Regex(@":(.*)-");
			Console.WriteLine(@"Regex: {0} - contains
Match: {1}    IN {2}
Match: {3}    IN {4}
", containsRegex.ToString()
									, containsRegex.Match(inputString).Value, inputString
									, containsRegex.Match(inputString2).Value, inputString2);

			var midstRegex = new Regex(@"^.+(?<group2>:.*-)");
			Console.WriteLine(@"Regex: {0} - contains
Match: {1}  IN {2}
Match: {3}      IN {4}
", midstRegex.ToString()
									, midstRegex.Match(inputString).Value, inputString
									, midstRegex.Match(inputString2).Value, inputString2);

		}
	}
}
