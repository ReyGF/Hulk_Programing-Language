using Microsoft.VisualBasic;

class Parser
{
    private readonly Token[] _tokens;

    private int _position;

    private Token Current
    {
        get => (_position >= _tokens.Length) ? new Token(TokenKind.EndLineToken, "\0")
                                             : _tokens[_position];

    }
    public Parser(Token[] tokens)
    {
        _tokens = tokens;
    }
}