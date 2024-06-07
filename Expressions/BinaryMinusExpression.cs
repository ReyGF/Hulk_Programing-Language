class BinaryMinusExpression : BinaryExpression
{
    public BinaryMinusExpression(Expression left, Expression right) : base(left, right) { }

    public override ExpressionKind Kind => ExpressionKind.BinaryMinusExpression;
}