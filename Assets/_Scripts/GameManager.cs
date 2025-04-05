using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject ball;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player1Goal;

    [SerializeField] GameObject player2;
    [SerializeField] GameObject player2Goal;

    [SerializeField] TextMeshProUGUI Player1Text;
    [SerializeField] TextMeshProUGUI Player2Text;

    private int player1Score;
    private int player2Score;

    [SerializeField] bool IAgame;

    [SerializeField] int maxScore = 5;

    public void CheckVictory()
    {
        if (player1Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer1");
        }
        if(player2Score >= maxScore)
        {
            if(player2.GetComponent<Players>() != null)
            {
                SceneManager.LoadScene("VictoryPlayer2");
            }
            else
            {
                SceneManager.LoadScene("VictoryIA");
            }
           
        }
    }

    public void Player1Scored()
    {
        player1Score++;
        Player1Text.text = player1Score.ToString();
        CheckVictory();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        Player2Text.text = player2Score.ToString();
        CheckVictory();
        ResetPosition();
    }

    public void ResetPosition()
    {

        if (IAgame)
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<IAenemy>().Reset();
        }
        else
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<Players>().Reset();

        }
    }



}
