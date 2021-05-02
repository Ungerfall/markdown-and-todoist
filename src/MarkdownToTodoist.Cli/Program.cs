using Antlr4.Runtime;
using MarkdownToTodoist.Parser;
using System;
using System.IO;

namespace MarkdownToTodoist.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "hello Leonid";
            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new TodoistGrammarLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            var parser = new TodoistGrammarParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ErrorListener());
            parser.BuildParseTree = true;
            var visitor = new TodoistGrammarVisitor();
            var ctx = parser.r();
            visitor.VisitR(ctx);
        }
    }

    public class ErrorListener : IAntlrErrorListener<IToken>
    {
        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine,
            string msg, RecognitionException e)
        {
            output.WriteLine(msg);
        }
    }
}
