internal sealed class BooleanExpression(bool boolean) : Expression
{
    public bool Boolean { get; } = boolean;
    public override ExpressionKind Kind => ExpressionKind.BoolExpression;
    public override object Evaluate()
    {
        return Boolean;
    }
}