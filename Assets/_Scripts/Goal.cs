using UnityEngine;

public class Goal : MonoBehaviour
{

    [SerializeField] bool player1Goal;
    [SerializeField] GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (player1Goal)
            {
                gameManager.GetComponent<GameManager>().Player2Scored();
            }
            else
            {
                gameManager.GetComponent<GameManager>().Player1Scored();
            }
        }
    }
}
