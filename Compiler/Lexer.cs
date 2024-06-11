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

        switch (Current)
        {
            case '+':
                return new PlusToken(TokenKind.PlusToken, "+");
            case '-':
                return new MinusToken(TokenKind.MinusToken, "-");
            case '*':
                return new TimesToken(TokenKind.TimesToken, "*");
            case '/':
                return new DivideByToken(TokenKind.DivideByToken, "/");
            case '^':
                return new PowToken(TokenKind.PowToken, "^");
            case '%':
                return new ModuleToken(TokenKind.ModuleToken, "%");
            case '(':
                return new OpenParenthesisToken(TokenKind.OpenParentesisToken, "(");
            case ')':
                return new CloseParenthesisToken(TokenKind.CloseParentesisToken, ")");
        }

        return new InvalidToken(TokenKind.InvalidToken, $"{Current}");


    }


}
