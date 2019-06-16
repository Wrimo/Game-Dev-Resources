using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRadar : MonoBehaviour
{
    public GameObject Parent;
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<AIAttack>() != null)
        {
            if (col.gameObject.GetComponent<Team>().TeamNum != Parent.GetComponent<Team>().TeamNum && col.gameObject.layer == 10)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                Parent.GetComponent<AIAttack>().Patrol = false;
                Parent.GetComponent<AIAttack>().Target = col.gameObject;
            }
        }

    }
    void OnTriggerExit2D(Collider2D col)
    {
        Invoke("ResetAI", 1f);
    }

    void ResetAI()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        Parent.GetComponent<AIAttack>().Patrol = true;
        Parent.GetComponent<AIAttack>().Target = null;
    }


}
