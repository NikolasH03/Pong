using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{

    void Start()
    {
        Invoke("LoadMainMenu",3);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
