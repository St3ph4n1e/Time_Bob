using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void Play()
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(2);
    }

   
   public void Quit()
    {
        Application.Quit();
    }
}
