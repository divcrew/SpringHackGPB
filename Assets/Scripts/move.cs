using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    private Rigidbody2D myRigid;

    private Animator anim;

    [SerializeField]
    private float speed;

    private bool facing;
	void Start () {
        facing = true;
        myRigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		
	}
	
	
	public void FixedUpdate ()
    {

        float horizontal = Input.GetAxis("Horizontal");
        Movement(horizontal);
        Face(horizontal);
    }

    private void Movement (float horizontal)
    {
        myRigid.velocity = new Vector2(horizontal * speed, myRigid.velocity.y);
        anim.SetFloat("speed", Mathf.Abs(horizontal)); 
    }
    private void Face(float horizontal)
    {
        if (horizontal>0 && !facing || horizontal < 0 && facing)
        {
            facing = !facing;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
