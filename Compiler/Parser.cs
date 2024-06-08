using Microsoft.VisualBasic;

class Parser
{
    private readonly Token[] _tokens;

    private int _position;

    private Token Current
    {
        get => (_position >= _tokens.Length) ? new Token(TokenKind.EndLineToken, "\0")
                                             : _tokens[_position];

    }
    public void Next()
    {
        _position++;
    }
    public Parser(Token[] tokens)
    {
        _tokens = tokens;
    }

    public Expression Parse() => T();

    private Expression T()
    {
        var left = E(Current);

        while (Current.TokenKind == TokenKind.PlusToken || Current.TokenKind == TokenKind.MinusToken)
        {
            var currentoperator = Current.TokenKind;

            Next();

            var right = E(Current);

            left = (currentoperator == TokenKind.PlusToken) ? new BinarySumExpression(left, right)
                                                            : new BinaryMinusExpression(left, right);
        }

        return left;

    }
    private Expression E(Token currentToken)
    {
        Next();

        if (currentToken.TokenKind == TokenKind.NumberToken)
        {
            return new NumberExpression(double.Parse(currentToken.Text));
        }

        return new ErrorExpression($"No se reconoce el token:{currentToken}");
    }
}