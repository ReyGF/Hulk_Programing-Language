internal sealed class UnaryNegationExpression(Expression expression) : Expression
{
    public Expression Expression { get; } = expression;
    public override ExpressionKind Kind => ExpressionKind.UnaryNegationExpression;

    public override object Evaluate() => !(bool)Expression.Evaluate();
}