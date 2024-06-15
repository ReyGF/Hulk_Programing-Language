sealed class NumberExpression(double number) : Expression
{
    public double Number { get; } = number;

    public override ExpressionKind Kind => ExpressionKind.NumberExpression;

    public override object Evaluate() => Number;
}