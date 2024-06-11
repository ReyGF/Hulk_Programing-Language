sealed class BinaryModuleExpression(Expression left, Expression right) : Expression, IBinary
{
    public Expression Left { get; } = left;

    public Expression Right { get; } = right;

    public override ExpressionKind Kind => ExpressionKind.BinaryPowExpression;

    public override object Evaluate()
    {
        return (double)Left.Evaluate() % (double)Right.Evaluate();
    }
}