interface ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> parse, Func<ISintaxNode, Expression> E, Func<Token> getToken, Action action);
}