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
        audioManager.PlayAudioUISelector();
        SceneManager.LoadScene(playerVsPlayer);
    }

    public void MoveToPlayerVsComputerScene()
    {
        audioManager.PlayAudioUISelector();
        SceneManager.LoadScene(playerVsComputer);
    }

    public void ResetScene()
    {
        audioManager.PlayAudioUISelector();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }

    public void ReturnToMenu()
    {
        audioManager.PlayAudioUISelector();
        SceneManager.LoadScene(mainMenu);
        gameManager.SetTimeScale(1.0f);
    }

    public void ExitGame()
    {
        audioManager.PlayAudioUISelector();
        Application.Quit();
    }
}
