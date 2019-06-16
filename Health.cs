using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int CurHealth;

    void Start()
    {
        CurHealth = MaxHealth;
    }


    void Update()
    {
        if (CurHealth <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    public void Damage(int damageAmount)
    {
        CurHealth -= damageAmount; 
    }

}
