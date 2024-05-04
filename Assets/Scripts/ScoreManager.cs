using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private GameManager gameManager = null;
    private Ball ball = null;

    [SerializeField] private Text player1ScoreText = null;    
    [SerializeField] private Text player2ScoreText = null;

    private int player1Score = 0;
    private int player2Score = 0;
    private int winningScore = 7;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        ball = FindObjectOfType<Ball>();
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
        if (player1Score == winningScore)
        {
            gameManager.DisplayPlayer1Wins();
        }

        if (player2Score == winningScore)
        {
            gameManager.DisplayPlayer2Wins();
        }

       /* if (gameObject.name == "Player1Wall")
        {
            ball.StartBall(-1.0f, 0.0f);
        }

        if (gameObject.name == "Player2Wall")
        {
            ball.StartBall(1.0f, 0.0f);
        }*/
    }
}
