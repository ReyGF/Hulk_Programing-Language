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
            return new Token(TokenKind.EndLineToken, "\n");

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

            return new Token(TokenKind.NumberToken, number);

        }

        switch (Current)
        {
            case '+':
                return new Token(TokenKind.PlusToken, "+");
            case '-':
                return new Token(TokenKind.MinusToken, "-");
            case '*':
                return new Token(TokenKind.TimesToken, "*");
            case '/':
                return new Token(TokenKind.DivideByToken, "/");
            case '^':
                return new Token(TokenKind.PowToken, "^");
            case '%':
                return new Token(TokenKind.ModuleToken, "%");
            case '(':
                return new Token(TokenKind.OpenParentesisToken, "(");
            case ')':
                return new Token(TokenKind.CloseParentesisToken, ")");
        }

        return new Token(TokenKind.InvalidToken, $"{Current}");


    }


}