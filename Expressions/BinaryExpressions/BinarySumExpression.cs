sealed class BinarySumExpression(Expression left, Expression right) : Expression, IBinary
{
    public Expression Left { get; } = left;
    public Expression Right { get; } = right;

    public override ExpressionKind Kind => ExpressionKind.BinarySumExpression;

    public override object Evaluate() => (double)Left.Evaluate() + (double)Right.Evaluate();

}