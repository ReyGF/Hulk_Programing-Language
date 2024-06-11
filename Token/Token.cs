internal abstract class Token(TokenKind TokenKind, string Text)
{
    public readonly string Text = Text;
    public readonly TokenKind TokenKind = TokenKind;
}