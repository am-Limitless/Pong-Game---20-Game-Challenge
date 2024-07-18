using UnityEngine;

public class AiPaddle : Paddle
{
    public Rigidbody2D ball;

    public AudioSource paddleHit;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0f)
        {

            if (ball.position.y > transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (ball.position.y < transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if (transform.position.y > 0f)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
            else if (transform.position.y < 0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            paddleHit.Play();
        }
    }
}
