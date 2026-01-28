using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            SceneManager.LoadScene("Title");
        }
    }
}
