sealed class NumberExpression : Expression
{
    public double Number { get; }

    public NumberExpression(double number)
    {
        Number = number;
    }
    public override ExpressionKind Kind => ExpressionKind.NumberExpression;

    public override object Evaluate()
    {
        return Number;
    }
}