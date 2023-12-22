
using UnityEngine;

public class PlayerPlace : MonoBehaviour
{
    
    void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;
    }

    
}
