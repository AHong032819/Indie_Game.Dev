using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpcontroller : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]int JumpPower;
    // Start is called before the first frame update
    [SerializeField]float Movespeed = 5f;
    [SerializeField]float fallMultiplier;
    public Transform GroundCheck;
    public LayerMask GroundLayer;
    bool isGrounded;
    Vector2 VecGravity;
    void Start()
    {
        VecGravity = new Vector2(0, -Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(GroundCheck.position,new Vector2(1.05f,0.2f),CapsuleDirection2D.Horizontal,0,GroundLayer);

        if(Input.GetButtonDown("Jump")&& isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x,JumpPower);
        }
        if(rb.velocity.y<0)
        {
            rb.velocity -= VecGravity*fallMultiplier*Time.deltaTime;
        }
    }
}