using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text player1WinsText;
    [SerializeField] private Text player2WinsText;

    public void DisplayPlayer1Wins()
    {
        player1WinsText.gameObject.SetActive(true);
    }
    public void DisplayPlayer2Wins()
    {
        player2WinsText.gameObject.SetActive(true);
    }
}
