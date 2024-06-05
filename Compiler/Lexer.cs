class Lexer
{
    private readonly string _text;

    private int _position;

    private char Current
    {
        get => (_position >= _text.Length) ? '\0' : _text[_position];
    }

    public Lexer(string text)
    {
        _text = text;
    }

    public IEnumerable<Token> GetTokens()
    {
        var tokens = new List<Token>();

        while (_position < _text.Length)
        {
            tokens.Add(GetToken());
            _position++;
        }
        return tokens;
    }

    private Token GetToken()
    {
        if (_position >= _text.Length)
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
        }

        return new Token(TokenKind.InvalidToken, $"{Current}");


    }


}