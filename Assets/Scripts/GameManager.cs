
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject[] objects;


    public static GameManager instance;
  

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de GameManager dans la scene");
            return;
        }

        instance = this;


        foreach (var elements in objects)
        {
            DontDestroyOnLoad(elements);
        }
    }



    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }



    public void Quit()
    {
        Application.Quit();
    }

    public void RemoveDontDestroy()
    {
        foreach (var elements in objects)
        {
            SceneManager.MoveGameObjectToScene(elements, SceneManager.GetActiveScene());
        }
            
    }
}
