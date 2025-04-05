using UnityEngine;

public class IAenemy : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] float speedIncrease = 0.5f;
    [SerializeField] float initialSpeed = 3;
    [SerializeField] GameObject ball;

    private Vector2 _ballPos;

    private void Start()
    {
        speed = initialSpeed;
        InvokeRepeating("IncreaseSpeed", 5f, 0.5f);
    }


    void Update()
    {
        Move();
    }
    void IncreaseSpeed()
    {
        speed += speedIncrease;
    }

    private void Move()
    {
        _ballPos = ball.transform.position;

        if(transform.position.y > _ballPos.y)
        {
            transform.position += new Vector3(0, -speed*Time.deltaTime);
        }
        if (transform.position.y < _ballPos.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
    }
    public void Reset()
    {
        speed = initialSpeed;
    }
}
