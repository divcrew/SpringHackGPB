using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {

    private Animator anim;
    private Rigidbody2D body;

    private float Speed = 2f;

    private bool moveLeft;
    private bool dontMove;


	
	void Start () {

        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();

        dontMove = true;
        
	}
	
	
	void Update () {

        HandleMovemtnt();

	}

    void HandleMovemtnt()
    {

        if (dontMove)
        {
            StopMoving();
        }
        else
        {
            if (moveLeft)
            {
                MoveLeft();
            }
            else if (!moveLeft)
            {
                MoveRight();
            }
           

        }
        }
    public void AllowMovement(bool movement)
    {
        dontMove = false;
        moveLeft = movement;
    }
    public void DontAllowMovement ()
    {
        dontMove = true;
        anim.SetFloat("speed", 0);
    }

    public void MoveLeft ()
    {
        body.velocity = new Vector2(-Speed, body.velocity.y);
        
    }
    public void MoveRight()
    {
        body.velocity = new Vector2(Speed, body.velocity.y);
        anim.SetFloat("speed", Speed);
    }
    public void StopMoving()
    {
        body.velocity = new Vector2(0f, body.velocity.y);

    }

}

