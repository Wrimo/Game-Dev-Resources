using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnTouch : MonoBehaviour
{
    public int Damage;
    public bool IsBullet; 
    void OnTriggerStay2D(Collider2D col)
    {
     
            if (col.gameObject.GetComponent<Team>().TeamNum != gameObject.GetComponent<Team>().TeamNum)
            {
                col.gameObject.GetComponent<Health>().Damage(Damage); 
                if(IsBullet)
                {
                    GameObject.Destroy(this.gameObject);
                }
            }
        
    }
}
