using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private GameManager gameManager = null;
    private AudioManager audioManager = null;

    private string playerVsPlayer = "PlayerVsPlayer";
    private string playerVsComputer = "PlayerVsComputer";
    private string mainMenu = "MainMenu";

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void MoveToPlayerVsPlayerScene()
    {
        SceneManager.LoadScene(playerVsPlayer);
    }

    public void MoveToPlayerVsComputerScene()
    {
        SceneManager.LoadScene(playerVsComputer);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(mainMenu);
        gameManager.SetTimeScale(1.0f);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
