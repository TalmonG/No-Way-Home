using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public Animator animator;
    
    public float speed = 0.01f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;

    public bool isSprinting = false;
    Vector3 velocity;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        animator.SetFloat("Speed", speed);


        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0) 
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded) 
        {
            

            FindObjectOfType<AudioManager>().Play("Jump");
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            FindObjectOfType<AudioManager>().Play("WalkOnGravel");
            Debug.Log ("bro");

        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;

        }
        else
        {
            isSprinting = false;
        }

        if (isSprinting == true)
        {
            speed = 24f;
        }

        if (isSprinting == false)
        {
            speed = 12f;
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
