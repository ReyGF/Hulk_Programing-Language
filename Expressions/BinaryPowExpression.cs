sealed class BinaryPowExpression : Expression, IBinary
{
    public Expression Left { get; }

    public Expression Right { get; }

    public BinaryPowExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }
    public override ExpressionKind Kind => ExpressionKind.BinaryPowExpression;

    public override object Evaluate()
    {
        return Math.Pow((double)Left.Evaluate(), (double)Right.Evaluate());
    }
}