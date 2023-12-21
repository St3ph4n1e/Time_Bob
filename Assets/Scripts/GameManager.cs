using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] objects;
    
    void Awake()
    {
        foreach(var elements in objects)
        {
            DontDestroyOnLoad(elements);
        }
    }

   
    void Update()
    {
        
    }
}
