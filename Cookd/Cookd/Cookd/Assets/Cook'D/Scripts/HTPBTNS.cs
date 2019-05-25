using UnityEngine;
using UnityEngine.SceneManagement;

public class HTPBTNS : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void MenuScreen()
    {
        SceneManager.LoadScene("Menu");
    }
}
