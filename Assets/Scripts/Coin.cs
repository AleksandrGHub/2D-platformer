using UnityEngine;

[RequireComponent(typeof(Collider2D), typeof(Rigidbody2D))]

public class Coin : MonoBehaviour
{
    private Collider2D _collider2D;
    private Rigidbody2D _rigidbody2D;
    private float _delay = 0.5f;
    private float _delayDestoy = 4f;

    private void Awake()
    {
        _collider2D = GetComponent<Collider2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _collider2D.enabled = false;
        Destroy(gameObject, _delayDestoy);
    }

    private void Update()
    {
        if (_delay <= 0)
        {
            _collider2D.enabled = true;
        }
        else
        {
            _delay -= Time.deltaTime;
        }
    }

    public void Toss(float coordinateX, float coordinateY)
    {
        _rigidbody2D.AddForce(new Vector2(coordinateX, coordinateY));
    }
}