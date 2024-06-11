internal sealed class NumberToken(TokenKind TokenKind, string Text) : Token(TokenKind, Text), ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> parse, Func<Token> getToken, ref int position)
    {
        return new NumberExpression(double.Parse(Text));
    }
}
