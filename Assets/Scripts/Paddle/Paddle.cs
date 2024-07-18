using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    public float speed = 10f;
    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
