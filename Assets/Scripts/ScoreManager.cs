using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private GameManager gameManager = null;

    [SerializeField] private Text player1ScoreText = null;    
    [SerializeField] private Text player2ScoreText = null;

    private int player1Score = 0;
    private int player2Score = 0;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

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

    private void Update()
    {
        if (player1Score == 7)
        {
            gameManager.DisplayPlayer1Wins();
        }

        if (player2Score == 7)
        {
            gameManager.DisplayPlayer2Wins();
        }
    }
}
