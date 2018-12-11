using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Firepont;
    public GameObject bulletPrefab;

    private float pCd;
    public float cd;

    private void Start()
    {
        pCd = cd;
    }

    // Update is called once per frame
    void Update()
    {
        if (pCd > 0)
        pCd -= Time.deltaTime;

        if (Input.GetButton("Fire1") && pCd <= 0)
        {
            Shoot();
        }
    }
     
    void Shoot ()
    {
        Instantiate(bulletPrefab, Firepont.position,bulletPrefab.transform.rotation);
        pCd = cd;
    }



}
