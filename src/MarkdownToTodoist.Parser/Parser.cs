using System;
using System.Collections.Generic;
using System.IO;
using MarkdownToTodoist.Core.Model;

namespace MarkdownToTodoist.Parser
{
	public class Parser
	{
		public IEnumerable<TodoistTask> Parse(StringReader inputMarkdownText)
		{
			var tokens = Tokenize(inputMarkdownText);
			throw new NotImplementedException();
		}

		private IEnumerable<Token> Tokenize(StringReader inputMarkdownText)
		{
			string line;
			while ((line = inputMarkdownText.ReadLine()) != null)
			{
				
				
			}

			throw new NotImplementedException();
		}
	}
}