interface ISintaxNode
{
    public Expression ToSintaxNode(Func<Expression> parse, Func<Token> getToken, ref int position);
}