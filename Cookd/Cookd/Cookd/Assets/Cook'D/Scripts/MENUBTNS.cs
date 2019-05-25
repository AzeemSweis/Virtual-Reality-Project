using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUBTNS : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
