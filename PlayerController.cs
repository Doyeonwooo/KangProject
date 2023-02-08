cusing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public GameObject player;        
    private float moveX = 0;
    private float speed = 0.0f;      
    private float moveSpeed = 3.0f;  
    private float maxSpeed = 4.0f;   
    private float jumpForce = 4.0f; 
    private int doubleJumpCount = 0; 
    public GameObject gameoverPanel; 
    public GameObject bgmObj;        
   
    bool doubleJumpState = true;    
    private Animator anim;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Jump();
        KeyboardMove();
    }


    public void Jump() 
    {
        bool jumpActive = Input.GetKeyDown(KeyCode.X); 
        if (jumpActive && doubleJumpState) 
        {
            anim.SetBool("jump", true);
            anim.SetBool("ground", false);
            rb.velocity = Vector2.up * jumpForce; 
            doubleJumpCount++;
            Debug.Log("Jump");
            if (doubleJumpCount >= 2)  
            {
                anim.SetBool("doubleJump", true);
                doubleJumpState = false;     
                Debug.Log("DoubleJump");
            }
        }

    }


    public void KeyboardMove() 
    {
        float xx = Input.GetAxisRaw("Horizontal");
        bool dash = Input.GetKey(KeyCode.Z);
        

        if (xx != 0) 
        {
            if (dash)  
            {
                speed = maxSpeed;
                anim.SetBool("run", true);
                Debug.Log("Dash");
            }
            else if(!dash)  
            {
                speed = moveSpeed;
                anim.SetBool("run", false);
                Debug.Log("Walk");
            }
            moveX = speed * xx;
            rb.velocity = new Vector2(moveX, rb.velocity.y);

            anim.SetBool("move", true);

        }
        else if(xx == 0) 
        {
            speed = 0.0f;
            anim.SetBool("move", false);
        }

        if(xx < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if(xx > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D col) 
    {
        if(col.gameObject.tag == "Trap")
        {
            gameObject.SetActive(false);
            gameoverPanel.SetActive(true);
            bgmObj.SetActive(false);
        }

        if(col.gameObject.tag == "Ground")
        {
            anim.SetBool("ground", true);
            anim.SetBool("jump", false);
            anim.SetBool("doubleJump", false);
            doubleJumpState = true;     
            doubleJumpCount = 0;  
            Debug.Log("Ground");
        }
        if(col.gameObject.tag != "Ground")
        {
            anim.SetBool("ground", false);
            anim.SetBool("jump", true);
            doubleJumpState = true;
        }
    }
}