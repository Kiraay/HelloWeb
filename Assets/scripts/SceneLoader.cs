using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene(2);
    }
}

