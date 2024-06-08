abstract class Expression : IEvaluator
{
    abstract public ExpressionKind Kind { get; }

    public abstract object Evaluate();

}