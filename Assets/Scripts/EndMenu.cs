
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
   

    [SerializeField]
    private TMP_Text m_EndText;



    private void Start()
    {   
        EndGame();
        

    }


    public void EndGame()
    {
        

        m_EndText.text = "Keep going Bobbie you will succeed Even if it takes time ";
        
    }

    public void Replay()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
