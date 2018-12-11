using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int maxHealth;
    public int health;

    public GameObject endscreen;
    
    public float deathDelay;

	// Use this for initialization
	void Start ()
    {
        regenHealth();
        endscreen.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (health <= 0)
            Die(deathDelay);
	}

    public void Die(float deathDelay)
    {
        health = 0;
        Destroy(gameObject, deathDelay);
        endscreen.SetActive(true);
    }

    public void regenHealth()
    {
        health = maxHealth;

    }

    public void TakeDmg(int dmg)
    {

        health -= dmg;
    }
}
