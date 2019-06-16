using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInput : MonoBehaviour
{
    public bool IsOnFire;
    public int FireCountdown;

    void Start()
    {
        gameObject.GetComponent<FireOutput>().SpreadFire = false; 
    }

    void Update()
    {
        if (IsOnFire)
        {
            gameObject.GetComponent<Health>().Damage(1);
            FireCountdown--;


            gameObject.GetComponent<FireOutput>().SpreadFire = true;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (FireCountdown == 0)
        {
            IsOnFire = false;
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            gameObject.GetComponent<FireOutput>().SpreadFire = false;

        }
    }

}
