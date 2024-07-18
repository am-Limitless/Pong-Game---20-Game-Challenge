using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _ballRigidbody2D;

    public float ballSpeed = 200f;

    private void Awake()
    {
        _ballRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPostion();
    }

    public void ResetPostion()
    {
        _ballRigidbody2D.position = Vector3.zero;
        _ballRigidbody2D.velocity = Vector3.zero;
        AddIntialForce();
    }

    private void AddIntialForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);

        _ballRigidbody2D.AddForce(direction * ballSpeed);
    }

    public void AddForce(Vector2 force)
    {
        _ballRigidbody2D.AddForce(force);
    }
}
