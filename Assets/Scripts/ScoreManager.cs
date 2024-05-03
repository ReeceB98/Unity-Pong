using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text player1ScoreText = null;    
    [SerializeField] private Text player2ScoreText = null;

    private int player1Score = 0;
    private int player2Score = 0;

    public void UpdatePlayer1Score()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
    }

    public void UpdatePlayer2Score()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
    }
}
