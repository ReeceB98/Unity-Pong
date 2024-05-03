using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private string playerVsPlayer = "PlayerVsPlayer";
    private string mainMenu = "MainMenu";

    public void MoveToPlayerVsPlayerScene()
    {
        SceneManager.LoadScene(playerVsPlayer);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
