using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;

    public Paddle AiPaddle;

    public TextMeshProUGUI _playerScoreText;

    public TextMeshProUGUI _aiScoreText;

    public GameObject playerWin;

    public GameObject aiWin;

    public AudioSource scoreSound;

    private int _playerScore;

    private int _aiScore;

    public void PlayerScore()
    {
        scoreSound.Play();
        _playerScore++;
        _playerScoreText.text = _playerScore.ToString();
        ResetLevel();
    }

    public void AiScore()
    {
        scoreSound.Play();
        _aiScore++;
        _aiScoreText.text = _aiScore.ToString();
        ResetLevel();
    }

    private void ResetLevel()
    {
        playerPaddle.ResetPosition();
        AiPaddle.ResetPosition();
        ball.ResetPostion();
        ball.AddIntialForce();
    }

    private void Update()
    {
        PlayerWin();
        AiWin();
    }

    public void PlayerWin()
    {
        if (_playerScore >= 5)
        {
            Debug.Log("Player Win");
            playerWin.SetActive(true);
        }
    }

    public void AiWin()
    {
        if (_aiScore >= 5)
        {
            Debug.Log("AI Win");
            Time.timeScale = 0;
            aiWin.SetActive(true);


        }
    }
}

