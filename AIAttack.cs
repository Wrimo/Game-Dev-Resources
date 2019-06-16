using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : MonoBehaviour
{

    public GameObject Bullet;
    public GameObject Target;
    public bool Patrol;
    public Vector3 Point1;
    public Vector3 Point2;

    public bool Position1;
    public bool Position2;
    public bool IsStationary;
    public bool RangedAttack;
    public bool TrackEnemy;
    public int bulletCooldown;

    void Start()
    {
        Patrol = true;
        Position1 = true;
        do
        {

            Point1 = new Vector3(transform.position.x + UnityEngine.Random.Range(-5, 6), transform.position.y + UnityEngine.Random.Range(-5, 6), transform.position.z);
            Point2 = new Vector3(transform.position.x - UnityEngine.Random.Range(-10, 11), transform.position.y - UnityEngine.Random.Range(-10, 11), transform.position.z);
        }
        while (Point1.x == Point2.x && Point1.y != Point2.y && Vector3.Distance(Point1, Point2) > 15);

        bulletCooldown = 60;
    }

    void Update()
    {
        MoveToEnemy();
        MoveBetweenPoints();
        FireAtEnemy();
    }

    private void FireAtEnemy()
    {
        if (Target != null && RangedAttack && bulletCooldown >= 30)
        {
            Bullet.transform.position = this.transform.position;
            Bullet.GetComponent<Bullet>().Target = Target.transform;
            Bullet.GetComponent<Team>().TeamNum = gameObject.GetComponent<Team>().TeamNum; 
            GameObject.Instantiate(Bullet);
            bulletCooldown = 0;
        }
        else if (RangedAttack)
        {
            bulletCooldown++; 
        }
    }

    private void MoveToEnemy()
    {
        if (Target != null && TrackEnemy)
        {
            MoveToPoint(Target.transform.position);
        }
        if (!TrackEnemy)
        {
            Patrol = true;
        }
    }

    private void MoveBetweenPoints()
    {
        if (Patrol && !IsStationary)
        {
            if (Position1)
            {
                MoveToPoint(Point1, true);
            }
            else if (Position2)
            {
                MoveToPoint(Point2, true);
            }
        }
    }

    public void MoveToPoint(Vector3 Point, bool isPatrol = false)
    {


        transform.position = Vector3.Lerp(transform.position, Point, 0.05f);

        if (Vector3.Distance(transform.position, Point) < 1)
        {
            Position2 = !Position2;
            Position1 = !Position2;
        }
    }
}
