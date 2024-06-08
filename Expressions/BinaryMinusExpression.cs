class BinaryMinusExpression : Expression
{
    public Expression Left { get; }
    public Expression Right { get; }
    public BinaryMinusExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }

    public override ExpressionKind Kind => ExpressionKind.BinaryMinusExpression;

    public override object Evaluate()
    {
        return (double)Left.Evaluate() - (double)Right.Evaluate();
    }
}