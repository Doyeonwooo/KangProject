using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControll : MonoBehaviour
{
    Rigidbody2D rb;
    int nextMove;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("Think",3);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(nextMove, rb.velocity.y);

        Vector2 frontVec = new Vector2(rb.position.x + nextMove, rb.position.y);
        Debug.DrawRay(frontVec, Vector3.down, new Color(0, 1, 0));

        RaycastHit2D rayHitGround = Physics2D.Raycast(frontVec, Vector3.down, 1, LayerMask.GetMask("Ground"));

        if(rayHitGround.collider == null)
        {
            nextMove = nextMove * (-1);
            CancelInvoke();
            Invoke("Think", 1);
        }
        
        if(nextMove > 0)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        else if(nextMove < 0)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
    }

    void Think()
    {
        nextMove = Random.Range(-1, 2);
        Invoke("Think", 7);
    }
}
