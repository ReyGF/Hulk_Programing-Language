sealed class BinaryModuleExpression : Expression, IBinary
{
    public Expression Left { get; }

    public Expression Right { get; }

    public BinaryModuleExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }
    public override ExpressionKind Kind => ExpressionKind.BinaryPowExpression;

    public override object Evaluate()
    {
        return (double)Left.Evaluate() % (double)Right.Evaluate();
    }
}