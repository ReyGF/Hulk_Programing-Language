internal class InvalidToken(TokenKind TokenKind, string Text) : Token(TokenKind, Text), ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> parse, Func<Token> getToken, ref int position)
    {
        return new ErrorExpression($"Missing {Text} Token");
    }
}
