using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Ball ball = null;

    [SerializeField] private Text player1WinsText;
    [SerializeField] private Text player2WinsText;

    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    public void DisplayPlayer1Wins()
    {
        ball.StopBall();
        player1WinsText.gameObject.SetActive(true);
    }
    public void DisplayPlayer2Wins()
    {
        ball.StopBall();
        player2WinsText.gameObject.SetActive(true);
    }
}
