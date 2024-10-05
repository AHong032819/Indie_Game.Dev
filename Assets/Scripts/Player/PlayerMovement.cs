using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f; 
    bool jump = false;
    bool Crouch = false;
    public Animator animator;


    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping",true);
        }
        if(Input.GetButtonDown("Crouch"))
        {
            Crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            Crouch = false;
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping",false);
    }
    public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}
    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,Crouch,jump);
        jump = false;
    }

}
