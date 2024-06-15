class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write(">");

            var input = Console.ReadLine();

            Console.WriteLine(new Parser(new Lexer(string.IsNullOrEmpty(input) ? "" : input).GetTokens()
                                                                                            .ToArray())
                                                                                            .Parse()
                                                                                            .Evaluate());
        }


    }
}
