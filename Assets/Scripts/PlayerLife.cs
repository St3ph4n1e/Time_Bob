using UnityEngine;
using System.Collections;


public class PlayerLife : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public bool invincible = false;
    public IEnumerator enumerator;
    public SpriteRenderer graphics;
    public float delay = 0.2f;
    public float delayAfterTouch = 3f;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }

        if (currentHealth <= 0)
        {
            GameOverManager.instance.EndGame();
            BobbieMoves.instance.m_Rigidb.bodyType = RigidbodyType2D.Kinematic ;
            BobbieMoves.instance.enabled = false;
     

        }
    }

   public void TakeDamage(int damage)
    {
        if(invincible == false)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);


            invincible = true;
            StartCoroutine(InvicibilityBlink());
            StartCoroutine(InvicibilityDelay());
        }

       
    }

    public IEnumerator InvicibilityBlink()
    {
        while (invincible)
        {
            graphics.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(delay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(delay);
        }
    }

    public IEnumerator InvicibilityDelay()
    {
        while (invincible)
        {
            
            yield return new WaitForSeconds(delayAfterTouch);
            invincible = false;
           
        }
    }

   
}
