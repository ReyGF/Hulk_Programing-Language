class BinarySumExpression : BinaryExpression
{
    public BinarySumExpression(Expression left, Expression right) : base(left, right) { }

    public override ExpressionKind Kind => ExpressionKind.BinarySumExpression;

}