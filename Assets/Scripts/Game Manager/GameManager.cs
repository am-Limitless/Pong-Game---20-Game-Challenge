using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;

    public Paddle AiPaddle;

    public TextMeshProUGUI _playerScoreText;

    public TextMeshProUGUI _aiScoreText;

    private int _playerScore;

    private int _aiScore;

    public void PlayerScore()
    {
        _playerScore++;
        _playerScoreText.text = _playerScore.ToString();

        ResetLevel();
    }

    public void AiScore()
    {
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
}

