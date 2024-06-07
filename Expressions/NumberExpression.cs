class NumberExpression : Expression
{
    public int Number { get; }

    public NumberExpression(int number)
    {
        Number = number;
    }
    public override ExpressionKind Kind => ExpressionKind.NumberExpression;
}