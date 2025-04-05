using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float speedIncrease = 0.5f;
    [SerializeField] float initialSpeed = 5;
    [SerializeField] Rigidbody2D rb;
    private Vector2 startPos;
    void Start()
    {
        transform.position = startPos;
        speed = initialSpeed;
        Launch();
        InvokeRepeating("IncreaseSpeed", 5f, 0.5f);
    }
    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.linearVelocity = new Vector2(x*speed, y*speed);

    }
    void IncreaseSpeed()
    {
            speed += speedIncrease;
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
    public void Reset()
    {
        transform.position=startPos;
        rb.linearVelocity = Vector2.zero;
        speed = initialSpeed;
        Launch();
    }
}
