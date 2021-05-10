using Antlr4.Runtime;
using System;
using System.IO;

namespace MarkdownToTodoist.Cli
{
    public class ConsoleErrorListener : IAntlrErrorListener<IToken>
    {
        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine,
            string msg, RecognitionException e)
        {
            throw new Exception(msg, e);
        }
    }
}