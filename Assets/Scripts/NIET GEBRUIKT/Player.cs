using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth, maxThirst, maxHunger;
    public float thirstIncreaseRate, hungryIncreaseRate;
    private float health, thirst, hunger;
    public bool dead;
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (!dead)
        {
            thirst += thirstIncreaseRate + Time.deltaTime;
            hunger += hungryIncreaseRate + Time.deltaTime;
        }

      if(thirst >= maxThirst)
            Die();

      if(hunger >= maxHunger)
            Die();

    }
    public void Die()
    {
        dead = true;
        print("Player has died");
    }
}
