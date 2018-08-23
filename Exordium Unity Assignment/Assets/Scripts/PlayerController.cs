using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float Speed;

    private Rigidbody2D _rigidBody;
    private Animator _anim;
    private bool _isMoving;
    private Vector2 _lastMove;
    
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D> ();
        _anim = GetComponent<Animator> ();
    }

    
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        _rigidBody.velocity = movement * Speed;
        _anim.SetFloat("MoveX", moveHorizontal);
        _anim.SetFloat("MoveY", moveVertical);
;
        if (movement == Vector2.zero)
        {
            _isMoving = false;
        } else { _isMoving = true; }

        _anim.SetBool("PlayerMoving", _isMoving);
        _anim.SetFloat("LastX",1.0f);//for testing
        _anim.SetFloat("LastY", 0f);//for testing
        
    }
}
