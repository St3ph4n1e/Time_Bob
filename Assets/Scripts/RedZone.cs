
using UnityEngine;
using System.Collections;


public class RedZone : MonoBehaviour
{

    private Transform playerPlace;
    private Animator fadeSystem;

    public int DamageOnCollision = 10;

    private void Awake()
    {
        playerPlace = GameObject.FindGameObjectWithTag("PlayerPlace").transform;
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSytem").GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            StartCoroutine(ReplacePlayer(collision));
            PlayerLife playerLife = collision.transform.GetComponent<PlayerLife>();
            playerLife.TakeDamage(DamageOnCollision);
        }
    }

    private IEnumerator ReplacePlayer(Collider2D collision)
    {
        fadeSystem.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        collision.transform.position = playerPlace.position;
    }
}
