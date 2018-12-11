using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public SpriteRenderer spriterend;

    public float speed;
    public float deathDelay;

    public float onHitSec = 0.5f;

    public int damage;
    public int maxhealth;
    public int health;

    public Score score;

    // Use this for initialization
    void Start()
    {
        health = maxhealth;
        score = GameObject.FindGameObjectWithTag("GameController").GetComponent<Score>();
        rb2d = GetComponent<Rigidbody2D>();
        spriterend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    virtual public void Update()
    {
        rb2d.velocity = -transform.up * speed;

        if (health <= 0)
        {
            health = 0;
            Die(deathDelay);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            HitFeedBack();
            col.SendMessageUpwards("TakeDmg", damage);


            Die(deathDelay);
        }
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
    }

    public void Die(float delay)
    {
        speed = 0;
        Destroy(gameObject, delay);
        score.pts += 100;
    }

    public void Fadeonhit(bool fade = true)
    {
        if (fade == true)
        {
            Debug.Log("alpha = 0.5");
            spriterend.color = new Color(1, 1, 1, 0.5f);
        }
        else if (fade == false)
        {
            Debug.Log("alpha = 1");
            spriterend.color = new Color(1, 1, 1, 1);
        }
    }


    IEnumerator HitFeedBack()
    {
        Fadeonhit();
        yield return new WaitForSeconds(onHitSec);
        Fadeonhit(false);
    }

}
