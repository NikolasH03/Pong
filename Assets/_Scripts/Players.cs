using UnityEngine;

public class Players : MonoBehaviour
{

    [SerializeField] bool player1;
    [SerializeField] float speed = 3;
    [SerializeField] float speedIncrease = 0.5f;
    [SerializeField] float initialSpeed = 3;
    [SerializeField] Rigidbody2D rb;

    private float _move;
    private Vector2 StartPos;


    private float moveSpeedTouchControl = 0.05f;
    void Start()
    {    
        speed = initialSpeed;
    StartPos = transform.position;
        InvokeRepeating("IncreaseSpeed", 5f, 0.5f);
    }


    void Update()
    {
        if (player1)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if(mousePos.x < -1)
                {
                    if (mousePos.y > 0.5)
                    {
                        transform.Translate(0, moveSpeedTouchControl, 0);
                    }
                    else if (mousePos.y < -0.5)
                    {
                        transform.Translate(0, -moveSpeedTouchControl, 0);
                    }
                }
            }
            _move = Input.GetAxisRaw("Vertical2");
        }
        else
        {

            if (Input.GetMouseButton(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (mousePos.x > 1)
                {
                    if (mousePos.y > 0.5)
                    {
                        transform.Translate(0, moveSpeedTouchControl, 0);
                    }
                    else if (mousePos.y < -0.5)
                    {
                        transform.Translate(0, -moveSpeedTouchControl, 0);
                    }
                }
            }

            _move = Input.GetAxisRaw("Vertical");
        }
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, _move*speed);
    }

    void IncreaseSpeed()
    {
        speed += speedIncrease;
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
    public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        speed = initialSpeed;
        transform.position = StartPos;
    }
}
