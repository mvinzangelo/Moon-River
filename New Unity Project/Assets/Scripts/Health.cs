using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    private int health;
    private int healthMax;
    HeartsUI HeartsUI;

    public Health(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }
    public int GetHealth()
    {
        return health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        HeartsUI.DecreaseHealth();
        if (health < 0)
        {
            health = 0;
        }
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
        HeartsUI.IncreaseHealth();
        if (health > healthMax)
        {
            health = healthMax;
        }
        
    }
}
