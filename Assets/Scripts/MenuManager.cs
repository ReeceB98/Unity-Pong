using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private string playerVsPlayer = "PlayerVsPlayer";
    private string mainMenu = "MainMenu";

    public void MoveToPlayerVsPlayerScene()
    {
        Debug.Log("Scene has moved to Player Vs Player.");
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
}
