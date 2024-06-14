internal sealed class UnaryNegativeExpression(Expression expression) : Expression
{
    public Expression Expression { get; } = expression;
    public override ExpressionKind Kind => ExpressionKind.UnaryNegativeExpression;
    public override object Evaluate()
    {
        return -(double)Expression.Evaluate();
    }
}