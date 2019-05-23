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
				if (line.Contains(Keywords.HEADER_PROJECT, StringComparison.InvariantCultureIgnoreCase))
				{
					yield return new ProjectToken {Payload = GetHeaderWithoutKeyword(line)};
				}
				else
				{
					if (line.Contains(Keywords.HEADER_TASK, StringComparison.InvariantCultureIgnoreCase))
					{
						yield return new TaskToken {Payload = GetHeaderWithoutKeyword(line)};
						foreach (var token in TokenizeTask(inputMarkdownText))
						{
							yield return token;
						}
					}

					continue;
				}
			}

			throw new NotImplementedException();
		}

		private IEnumerable<Token> TokenizeTask(StringReader inputMarkdownText)
		{
			throw new NotImplementedException();
		}

		private string GetHeaderWithoutKeyword(string line)
		{
			return line.Replace(Keywords.HEADER_PROJECT, string.Empty).Trim();
		}
	}
}