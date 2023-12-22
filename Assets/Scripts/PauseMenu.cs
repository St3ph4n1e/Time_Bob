using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool paused = false;

    public GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            } else
            {
                Paused();
            }
        } 
    }

     void Paused()
    {
        BobbieMoves.instance.enabled = false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        paused = true;
    }

   public void Resume()
    {
        BobbieMoves.instance.enabled = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        pauseMenuUI.SetActive(false);
        GameManager.instance.RemoveDontDestroy();
        GameManager.instance.enabled = false;
    }
}
