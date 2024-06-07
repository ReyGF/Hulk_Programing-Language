class ErrorExpression : Expression
{
    public string Text { get; }

    public ErrorExpression(string text)
    {
        Text = text;
    }
    public override ExpressionKind Kind => ExpressionKind.ErrorExpression;
}