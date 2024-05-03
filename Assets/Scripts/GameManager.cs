using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Ball ball = null;

    [SerializeField] private Text player1WinsText;
    [SerializeField] private Text player2WinsText;

    [SerializeField] private Button tryAgainButton;
    [SerializeField] private Button menuButton;

    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    public void DisplayPlayer1Wins()
    {
        ball.StopBall();
        player1WinsText.gameObject.SetActive(true);
        DisplayGUI();
    }
    public void DisplayPlayer2Wins()
    {
        ball.StopBall();
        player2WinsText.gameObject.SetActive(true);
        DisplayGUI();
    }

    private void DisplayGUI()
    {
        tryAgainButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
    }
}
