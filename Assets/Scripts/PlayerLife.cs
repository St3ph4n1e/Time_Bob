using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public bool invincible = false;
    public IEnumerator enumerator;
    public SpriteRenderer graphics;

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
    }

   public void TakeDamage(int damage)
    {
        if(invincible == false)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }

        while (invincible)
        {
            
        }
    }
}
