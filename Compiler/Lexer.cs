internal sealed class Lexer(string text)
{
    private int _position;

    private char Current
    {
        get => (_position >= text.Length) ? '\0' : text[_position];
    }

    public IEnumerable<Token> GetTokens()
    {
        var tokens = new List<Token>();

        while (_position < text.Length)
        {
            tokens.Add(GetToken());
            _position++;
        }
        return tokens;
    }

    private Token GetToken()
    {
        if (_position >= text.Length)
            return new EndLineToken(TokenKind.EndLineToken, "\n");

        while (char.IsWhiteSpace(Current))
        {
            _position++;
        }

        if (char.IsDigit(Current))
        {
            var number = "";
            while (char.IsDigit(Current))
            {
                number += Current;
                _position++;
            }
            _position--;

            return new NumberToken(TokenKind.NumberToken, number);

        }

        return Current switch
        {
            '+' => new PlusToken(TokenKind.PlusToken, "+"),
            '-' => new MinusToken(TokenKind.MinusToken, "-"),
            '*' => new TimesToken(TokenKind.TimesToken, "*"),
            '/' => new DivideByToken(TokenKind.DivideByToken, "/"),
            '^' => new PowToken(TokenKind.PowToken, "^"),
            '%' => new ModuleToken(TokenKind.ModuleToken, "%"),
            '(' => new OpenParenthesisToken(TokenKind.OpenParentesisToken, "("),
            ')' => new CloseParenthesisToken(TokenKind.CloseParentesisToken, ")"),
            _ => new InvalidToken(TokenKind.InvalidToken, $"{Current}"),
        };
    }


}
