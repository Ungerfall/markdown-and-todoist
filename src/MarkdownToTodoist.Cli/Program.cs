using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using MarkdownToTodoist.Core.Model;
using System;
using System.Globalization;
using System.IO;

namespace MarkdownToTodoist.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "%2020-01-22T21:03:33%";
            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new TodoistGrammarLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            var parser = new TodoistGrammarParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ErrorListener());
            parser.BuildParseTree = true;
            var visitor = new Visitor();
            IParseTree tree = parser.project();
            var project = visitor.Visit(tree);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(project));

            Console.ReadLine();
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

    public class Visitor : TodoistGrammarBaseVisitor<TodoistProject>
    {
        private TodoistProject project;

        public override TodoistProject VisitProject(TodoistGrammarParser.ProjectContext context)
        {
            project = new TodoistProject();
            return base.VisitProject(context);
        }

        public override TodoistProject VisitDate(TodoistGrammarParser.DateContext context)
        {
            var datetimeString = context.GetText();
            project.Date = DateTime.ParseExact(context.GetText(), "yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture);
            return project;
        }
    }
}
