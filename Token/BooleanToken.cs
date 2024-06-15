
internal class BooleanToken(TokenKind TokenKind, string Text) : Token(TokenKind, Text), ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> parse, Func<ISintaxNode, Expression> E, Func<Token> getToken, Action action)
    {
        return new BooleanExpression("True" == Text);
    }
}