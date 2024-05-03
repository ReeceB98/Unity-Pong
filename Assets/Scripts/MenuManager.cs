using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private string playerVsPlayer = "PlayerVsPlayer";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToPlayerVsPlayerScene()
    {
        Debug.Log("Scene has moved to Player Vs Player.");
        SceneManager.LoadScene(playerVsPlayer);
    }
}
