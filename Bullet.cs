using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform Target;
    public int timer = 0;

    private float speed = 12f;
    private int direction;
    Vector3 moveDir;

    void Start()
    {
        Vector3 direction = new Vector3(Target.position.x + UnityEngine.Random.Range(-4, 5), Target.position.y, Target.position.z);
        moveDir = (Target.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsTarget();
    }

    private void MoveTowardsTarget()
    {

        transform.position += moveDir * speed * Time.deltaTime;

        if (timer == 360)
        {
            DestroyBullet();
        }
        else
        {
            timer++;
        }

    }
    private void DestroyBullet()
    {
        GameObject.Destroy(this.gameObject);
    }
    public float AngleDir(Vector3 A, Vector3 B)
    {
        return -A.x * B.y + A.y * B.x;
    }
}
