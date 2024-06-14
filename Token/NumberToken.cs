internal sealed class NumberToken(TokenKind TokenKind, string Text) : Token(TokenKind, Text), ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> Parse, Func<ISintaxNode, Expression> E, Func<Token> GetCurrent, Action Next)
    {
        return new NumberExpression(double.Parse(Text));
    }
}
