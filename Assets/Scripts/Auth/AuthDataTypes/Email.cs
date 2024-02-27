using System.Text.RegularExpressions;

public class Email
{

    public const string DATA_TYPE = "Email";

    private string _email;

    public Email(string email)
    {
        _email = email;
    }

    public string GetEmail()  { return _email;}

    public bool IsValidEmail()
    {
        if (string.IsNullOrEmpty(_email)) return false;
        try
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(_email, pattern);
        }
        catch
        {
            return false;
        }
    }
}