using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController controller;
    public float speed = 12f;
    // Update is called once per frame
    Vector3 velocity;
    public bool grounded; 
    public float gravity = -9.81f;
    public Transform check;
    public float Distance;
    public LayerMask GroundMask;
    public float JumpHeight = 3;
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>(); 
    }
    void Update()
    {
        grounded = Physics.CheckSphere(check.position, Distance, GroundMask);
        if(grounded && velocity.y < 0)
        {
            velocity.y = -2f; 
        }
     
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed *  Time.deltaTime);
        if (grounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
        }

            velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
