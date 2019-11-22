using UnityEngine.SceneManagement;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    private void Start() {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LaunchGame() {
        SceneManager.LoadScene("jeu");
    }

    public void QuitGame() {
        Application.Quit();
    }

    
}
