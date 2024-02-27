using System;
using UnityEngine;
using UnityEngine.UI;

public class UserInputManager : MonoBehaviour
{

    [SerializeField] private Text _name;
    [SerializeField] private Text _email;
    [SerializeField] private Text _pass;
    [SerializeField] private Text _reEnteredPass;


    [SerializeField] private AuthManager auth;


    public void OnSignInButtonClick()
    {
        AuthData authData = new AuthData(_name.text, _email.text, _pass.text, _reEnteredPass.text);

    }

    private bool ValidateInputs(AuthData authData)
    {
        throw new NotImplementedException();
    }

    private bool IsInputValid(string userInput, string userInputName)
    {
        if (string.IsNullOrEmpty(userInput))
        {
            Debug.Log($"{userInputName} isn`t valid");
            return false;
        }

        return true;
    }

    private bool IsPasswordMatch(Text pass, Text rePass)
    {
        if (pass != rePass)
        {
            Debug.Log("Password doesn`t match");
            return false;
        }

        Debug.Log("Password is match");

        return true;
    }

}
