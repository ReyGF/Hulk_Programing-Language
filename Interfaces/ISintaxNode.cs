interface ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> Parse, Func<ISintaxNode, Expression> E, Func<Token> GetCurrent, Action Next);
}