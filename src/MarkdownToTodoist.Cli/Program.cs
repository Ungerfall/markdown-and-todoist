using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using MarkdownToTodoist.Parser;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace MarkdownToTodoist.Cli
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args == null || !File.Exists(args[0]))
            {
                throw new ArgumentException("File is required", nameof(args));
            }

            string input = await File.ReadAllTextAsync(args[0]);

            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new TodoistGrammarLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            // PrintTokens(tokens, input.Length);
            var parser = new TodoistGrammarParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ConsoleErrorListener());
            parser.BuildParseTree = true;
            var visitor = new Visitor();
            IParseTree tree = parser.project();
            var project = visitor.Visit(tree);

            Console.WriteLine(JsonSerializer.Serialize(
                project,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }));

            Console.ReadLine();
        }

        private static void PrintTokens(ITokenStream tokens, int inputLength)
        {
            for (int i = 0; i < inputLength; i++)
            {
                try
                {
                    tokens.Consume();
                    var token = tokens.Get(i);
                    var symbolicName = TodoistGrammarLexer.DefaultVocabulary.GetSymbolicName(token.Type);
                    Console.WriteLine(symbolicName);
                }
                catch
                {
                    tokens.Seek(0);
                    break;
                }
            }
        }
    }
}
