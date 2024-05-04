using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    private Ball ball = null;
    private InputSystem inputSystem = null;

    [SerializeField] private Text player1WinsText;
    [SerializeField] private Text player2WinsText;

    [SerializeField] private Button tryAgainButton;
    [SerializeField] private Button menuButton;

    private bool pausingGame = false;

    [SerializeField] private GameObject pause;

    private void Awake()
    {
        inputSystem = new InputSystem();
 
    }

    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    private void OnEnable()
    {
        inputSystem.Enable();
        inputSystem.GameMenu.Pause.started += PauseGame;
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

    private void PauseGame(InputAction.CallbackContext value)
    {
        if (this != null)
        {
            // Pauses the game.
            if (value.started && !pausingGame)
            {
                Time.timeScale = 0.0f;
                pause.SetActive(true);
                pausingGame = true;
            }
            // Unpauses the game.
            else if (value.started && pausingGame)
            {
                Time.timeScale = 1.0f;
                pause.SetActive(false);
                pausingGame = false;
            }
        }
    }

    public void SetTimeScale(float value)
    {
        Time.timeScale = value;
    }
}
