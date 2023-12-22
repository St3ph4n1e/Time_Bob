using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    public static GameOverManager instance;
    public GameObject gameOverUI;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de GameOverManager dans la sc?ne");
            return;
        }

        instance = this;
    }

    

    public void EndGame()
    {
        gameOverUI.SetActive(true);
    }



    public void Replay()
    {
        gameOverUI.SetActive(false);
        GameManager.instance.RemoveDontDestroy();
        GameManager.instance.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void Menu()
    {
        gameOverUI.SetActive(false);
        GameManager.instance.RemoveDontDestroy();
        GameManager.instance.enabled = false;
        SceneManager.LoadScene(0);
        
    }



    public void Quit()
    {
        Application.Quit();
    }

}
