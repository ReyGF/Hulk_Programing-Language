class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write(">");

            var input = "";//Console.ReadLine();

            System.Console.WriteLine(new Parser(
                                     new Lexer(input).GetTokens()
                                                     .ToArray())
                                                     .Parse()
                                                     .Evaluate());

        }


    }
}
