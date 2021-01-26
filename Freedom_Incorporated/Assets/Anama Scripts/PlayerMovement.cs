using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController2D controller2D;
    Animator animator;

    public float runSpeed = 40f;

    float horMove = 0f;

    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        controller2D = GetComponent<CharacterController2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horMove)); 



        if(Input.GetButtonDown("Jump") && controller2D.m_Grounded == true)
        {
            jump = true;
            animator.SetTrigger("OnJumping");
        }
    }

    public void OnLanding()
    {
        animator.SetTrigger("OnLanding");
    }

    void FixedUpdate()
    {
        controller2D.Move(horMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
