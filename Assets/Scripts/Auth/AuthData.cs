
public class AuthData
{
    public Name Name { get; }
    public Email Email { get; }
    public Pass Password { get; }
    public string ReEnteredPass { get; }

    public AuthData(string name, string email, string pass, string reEnteredPass)
    {
        Name = new Name(name);
        Email = new Email(email);
        Password = new Pass(pass);
        ReEnteredPass = reEnteredPass;
    }
}