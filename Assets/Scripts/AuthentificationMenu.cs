using UnityEngine;
using Unity.Services.Authentication;
using TMPro;

public class AuthentificationMenu : MonoBehaviour
{
    public TMP_InputField UsernameInput;
    public TMP_InputField passwordInput;    
    public string user;
    public string pass;
    public TextMeshProUGUI UserNameUI;
    /*public void SignUp()
    {
         user = UsernameInput.text.Trim();
         pass = passwordInput.text.Trim();
        if (string.IsNullOrEmpty(user) == false && string.IsNullOrEmpty(pass) == false)
        {
            MenuManager.Instance.SignInWithUsernameAndPasswordAsync(user, pass);
            MenuManager.Instance.MainMenuCanvas();
            SignInConfirmAsync();
            UpdatePlayerName();
        }
        

    }
    public void SignIn()
    {
        user = UsernameInput.text.Trim();   
        pass = passwordInput.text.Trim(); 
        if (string.IsNullOrEmpty(user) == false && string.IsNullOrEmpty(pass) == false)
        {
            MenuManager.Instance.SignInWithUsernameAndPasswordAsync(user, pass);
            MenuManager.Instance.MainMenuCanvas();
            SignInConfirmAsync();
            UpdatePlayerName();
        }
        
    }
    public async void SignInConfirmAsync()
    {
        if (string.IsNullOrEmpty(AuthenticationService.Instance.PlayerName))
        {
            await AuthenticationService.Instance.UpdatePlayerNameAsync(user);
        }
    }
    public void UpdatePlayerName()
    {
        
        UserNameUI.text = AuthenticationService.Instance.PlayerName;
        
    }*/
}
