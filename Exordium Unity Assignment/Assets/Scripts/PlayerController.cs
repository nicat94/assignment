using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float Speed;

    private Rigidbody2D _rigidBody;
    private Animator _anim;
    
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
        
    }
}
