sealed class Token
{
    public readonly string Text;
    public readonly TokenKind TokenKind;

    public Token(TokenKind TokenKind, string Text)
    {
        this.Text = Text;
        this.TokenKind = TokenKind;
    }


}