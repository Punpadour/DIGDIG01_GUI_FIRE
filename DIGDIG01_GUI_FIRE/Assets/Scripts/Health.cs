using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public int currentHealth = 50;
    public int maxHealth = 100;
    public int dmg = 10;
    public int healt = 15;

    public HealthBar healthBar;

    public SpriteRenderer spriteRenderer;

    public Sprite healthyMonster;
    public Sprite hurtMonster;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(healthBar.gameObject);
            Destroy(gameObject);
        }

        if (currentHealth < 50)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = hurtMonster;
        }

        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = healthyMonster;
        }



    }

    public void TakeDamage ()

    {
        currentHealth -= dmg;
        healthBar.SetHealth(currentHealth);

    }
   
    public void HealHealth ()
    {
        if(currentHealth < maxHealth)
        {
            currentHealth += healt;
            healthBar.SetHealth(currentHealth);
        }

        else
        {
            currentHealth = maxHealth;
        }
    }


}
