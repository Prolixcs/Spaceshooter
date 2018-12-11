using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }
}
