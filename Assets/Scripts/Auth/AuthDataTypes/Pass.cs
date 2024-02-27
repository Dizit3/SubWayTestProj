

public class Pass
{
    public const string DATA_TYPE = "Password";

    private string _pass { get; }

    public Pass(string pass)
    {
        _pass = pass;
    }
    public string GetPass() { return _pass; }
}
