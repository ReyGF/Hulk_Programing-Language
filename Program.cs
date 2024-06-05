class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write(">");

            var input = Console.ReadLine();

            if (input == "stop") return;

            if (string.IsNullOrEmpty(input)) return;

            var lexer = new Lexer(input);

            var tokens = lexer.GetTokens();

            foreach (Token token in tokens)
            {
                Console.WriteLine($"{token.Text} : {token.TokenKind}");
            }

        }

    }
}
