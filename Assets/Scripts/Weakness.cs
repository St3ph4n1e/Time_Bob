using UnityEngine;

public class Weakness : MonoBehaviour
{

    public GameObject objectToDestroy;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(objectToDestroy);
        }
    }

}