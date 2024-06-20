internal class InvalidToken(TokenKind TokenKind, string Text) : Token(TokenKind, Text), ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> Parse, Func<ISintaxNode, Expression> E, Func<Token> GetCurrent, Action Next)
    {
        return new ErrorExpression($"Missing '{Text}' Token");
    }
}
