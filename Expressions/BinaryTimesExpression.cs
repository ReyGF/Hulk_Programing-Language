class BinaryTimesExpression : Expression
{
    public Expression Left { get; }
    public Expression Right { get; }
    public BinaryTimesExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }

    public override ExpressionKind Kind => ExpressionKind.BinarySumExpression;

    public override object Evaluate()
    {
        return (double)Left.Evaluate() * (double)Right.Evaluate();
    }

}