using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void ElegirEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
