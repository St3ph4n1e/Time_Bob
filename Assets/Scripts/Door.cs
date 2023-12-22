
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            
            SceneManager.LoadScene(4);
            GameManager.instance.RemoveDontDestroy();
            GameManager.instance.enabled = false;
         
        }
    }
}
 