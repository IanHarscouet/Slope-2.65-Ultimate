using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.Services.Authentication;
using Unity.Services.Core;


public class MenuManager : MonoBehaviour
{    
    public static MenuManager Instance;
    public Canvas OptionCanvas;
    public Canvas LeaderboardCanvas;
    public Canvas MainCanvas;
    public Canvas SignInCanvas;
    public void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Doublon Menu Manager");
        }
        Instance = this;
        //StartClientService();
    }
    /*public async void StartClientService()
    {
        if (UnityServices.State != ServicesInitializationState.Initialized)
        {
            var config = new InitializationOptions();
            config.SetProfile("default_profile");
            await UnityServices.InitializeAsync();
        }
    }
    public async void LoginAnonymeAsync()
    {
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }

    public async void SignInWithUsernameAndPasswordAsync(string username, string password)
    {
        await AuthenticationService.Instance.SignInWithUsernamePasswordAsync(username, password); 
    }

    public async void SignUpWithUsernameAndPasswordAsync(string username, string password)
    {
        await AuthenticationService.Instance.SignUpWithUsernamePasswordAsync(username, password);
    }

    public async void SignInConfirmAsync()
    {
        if (string.IsNullOrEmpty(AuthenticationService.Instance.PlayerName))
        {
            await AuthenticationService.Instance.UpdatePlayerNameAsync("Player");
        }
    }

    public void  SignOut()     
    {
         AuthenticationService.Instance.SignOut(true);

    }*/


    public static void Jouer()
    {
        SceneManager.LoadScene(1);
    }

    public static void Retour()
    {
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex - 1);
    }
    public static void Tutoriel()
    {
        SceneManager.LoadScene("Tutoriel");
    }
    public static void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");// Pour les tests dans l'éditeur
        Application.Quit();
    }

    //Mauvaise méthode pour afficher les différents panel => j'aurais dû passer directement par un Manager pour les différents panel
    public void OptionMenu()
    {
        OptionCanvas.enabled = true;
        MainCanvas.enabled = false;
        LeaderboardCanvas.enabled = false;
        SignInCanvas.enabled = false;

    }
    public void LeaderboardMenu()
    {
        OptionCanvas.enabled = false;
        MainCanvas.enabled = false;
        LeaderboardCanvas.enabled = true;
        SignInCanvas.enabled = false ;
    }
    public void MainMenuCanvas()
    {
        MainCanvas.enabled = true;
        OptionCanvas.enabled = false;        
        LeaderboardCanvas.enabled = false;
        SignInCanvas.enabled = false;

    }
    public void SignInMenu()
    {
        MainCanvas.enabled = false;
        OptionCanvas.enabled = false;
        LeaderboardCanvas.enabled = false;
        SignInCanvas.enabled = true;
    }
   
    
}
        


         
    

