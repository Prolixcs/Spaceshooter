using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDodge : Enemy
{
    public bool goingUp = true;
    public float dodgeSpeed = 1;

    private float Angle = 90;

    public override void Update()
    {
        base.Update();

        rb2d.velocity = new Vector2(-speed , Mathf.Sin(Time.time * dodgeSpeed));
    
        //transform.rotation = transform.rotation.z * Angle;

        //rb2d.angularVelocity = goingUp ? speed * 90f : -speed * 90f;
    }

}
