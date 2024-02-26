using UnityEngine;
using UnityEngine.UI;

public class UserInputManager : MonoBehaviour
{
    [SerializeField] private Text _name;
    [SerializeField] private Text _email;
    [SerializeField] private Text _pass;
    [SerializeField] private Text _rePass;


    public class Name
    {
        private string _name;
        public Name(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            if (_name != null && _name != string.Empty)
            {
                return _name;

            }

            _name = "Undefined";
            return _name;
        }

    }
    public class Email
    {
        private string _email;

        public Email(string email)
        {
            _email = email;
        }

        public string GetEmail()
        {
            if (_email != null && _email != string.Empty)
            {
                return _email;

            }

            _email = "Undefined";
            return _email;
        }

    }
    public class Pass
    {
        private string _pass;

        public Pass(string pass)
        {
            _pass = pass;
        }

        public string GetEmail()
        {
            if (_pass != null && _pass != string.Empty)
            {
                return _email;

            }

            _email = "Undefined";
            return _email;
        }
    }


    public void OnSignInButtonClick()
    {
        Debug.Log("Try to Sign In");

        CheckUserEmptyFields(_name, _email, _pass, _rePass);




        Debug.Log("Sign In Successfully");

    }

    private void CheckUserEmptyFields(Text name, Text email, Text pass, Text rePass)
    {





    }
}
