internal sealed class Parser(Token[] tokens)
{
    private int _position;

    private Token Current
    {
        get => (_position >= tokens.Length) ? new EndLineToken(TokenKind.EndLineToken, "\0")
                                            : tokens[_position];

    }
    private void Next()
    {
        _position++;
    }

    public Expression Parse() => T();

    private Expression T()
    {
        var left = F();

        while (Current.TokenKind == TokenKind.PlusToken || Current.TokenKind == TokenKind.MinusToken)
        {
            var currentoperator = Current.TokenKind;

            Next();
            var right = F();

            left = (currentoperator == TokenKind.PlusToken) ? new BinarySumExpression(left, right)
                                                            : new BinaryMinusExpression(left, right);
        }

        return left;

    }

    private Expression F()
    {
        var left = P();

        while (Current.TokenKind == TokenKind.TimesToken || Current.TokenKind == TokenKind.DivideByToken ||
               Current.TokenKind == TokenKind.ModuleToken)
        {
            var currentoperator = Current.TokenKind;

            Next();
            var right = P();

            switch (currentoperator)
            {
                case TokenKind.TimesToken:
                    left = new BinaryTimesExpression(left, right);
                    break;
                case TokenKind.DivideByToken:
                    left = new BinaryDivideByExpression(left, right);
                    break;
                case TokenKind.ModuleToken:
                    left = new BinaryModuleExpression(left, right);
                    break;
            }

        }

        return left;
    }

    private Expression P()
    {
        var left = E((ISintaxNode)Current);

        while (Current.TokenKind == TokenKind.PowToken)
        {
            Next();
            var right = E((ISintaxNode)Current);

            left = new BinaryPowExpression(left, right);
        }
        return left;
    }


    private Expression E(ISintaxNode currentToken)
    {
        Next();

        Token getCurrent() => Current;

        return currentToken.ToSintaxNode(Parse, getCurrent, ref _position);
    }
}