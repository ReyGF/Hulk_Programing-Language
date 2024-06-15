sealed class BinaryMinusExpression(Expression left, Expression right) : Expression, IBinary
{
    public Expression Left { get; } = left;
    public Expression Right { get; } = right;

    public override ExpressionKind Kind => ExpressionKind.BinaryMinusExpression;

    public override object Evaluate() => (double)Left.Evaluate() - (double)Right.Evaluate();
}