sealed class BinaryPowExpression(Expression left, Expression right) : Expression, IBinary
{
    public Expression Left { get; } = left;

    public Expression Right { get; } = right;

    public override ExpressionKind Kind => ExpressionKind.BinaryPowExpression;

    public override object Evaluate() => Math.Pow((double)Left.Evaluate(), (double)Right.Evaluate());
}