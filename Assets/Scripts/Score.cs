using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text score;
    public Text healthText;

    public int pts;
    public Health health;
    


    // Use this for initialization
    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Points: " + pts.ToString();
        healthText.text = "Health: " + health.health.ToString();
    }
}
