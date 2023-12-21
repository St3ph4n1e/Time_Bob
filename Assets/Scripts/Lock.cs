
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lock : MonoBehaviour
{
   
    public Animator fadeSystem;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                StartCoroutine(NextScene());
               
            }
            else
            {
                Debug.LogWarning("No next scene available.");
            }
        }
    }

    public IEnumerator NextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSytem").GetComponent<Animator>();
        fadeSystem.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextSceneIndex);
    }
}
