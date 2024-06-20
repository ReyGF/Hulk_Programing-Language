
internal class OpenParenthesisToken(TokenKind TokenKind, string Text) : Token(TokenKind, Text), ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> Parse, Func<ISintaxNode, Expression> E, Func<Token> GetCurrent, Action Next)
    {
        var parenthesisExpression = Parse();

        if (GetCurrent() is not CloseParenthesisToken)
            return new ErrorExpression("ERROR:Missing ')' close parenthesis");

        Next();

        return parenthesisExpression;
    }
}
