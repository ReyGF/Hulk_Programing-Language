class ErrorExpression(string text) : Expression
{
    public string Text { get; } = text;

    public override ExpressionKind Kind => ExpressionKind.ErrorExpression;

    public override object Evaluate() => Text;

}