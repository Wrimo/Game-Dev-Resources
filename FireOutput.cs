using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOutput : MonoBehaviour
{
    public bool SpreadFire;
    public int Cooldown;
    private int random;
    public bool Timer;
    void OnTriggerStay2D(Collider2D col)
    {
        if (Timer)
        {
            if (SpreadFire && (Cooldown == random || Cooldown == 60))
            {
                SpreadTheFire(col);
            }
            else if (SpreadFire)
            {
                Cooldown++;
            }
        }
        else
        {
            SpreadTheFire(col); 
        }


    }
    void Start()
    {
        Cooldown = 60;
        random = UnityEngine.Random.Range(30, 60);
    }
    private void SpreadTheFire(Collider2D col)
    {
        try
        {
            col.gameObject.GetComponent<FireInput>().IsOnFire = true;
            col.gameObject.GetComponent<FireInput>().FireCountdown = 30;
            Cooldown = 0;
            random = UnityEngine.Random.Range(30, 60);
        }
        catch
        {
            //shhhh
        }
    }
}



