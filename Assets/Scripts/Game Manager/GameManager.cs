using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    private int _playerScore;

    private int _aiScore;

    public void PlayerScore()
    {

        _playerScore++;
        ball.ResetPostion();
    }

    public void AiScore()
    {
        _aiScore++;
        ball.ResetPostion();
    }
}

