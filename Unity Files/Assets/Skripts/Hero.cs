using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public Rigidbody Ball;
    public bool grounded;
    public float speed;

    public void Awake()
    {
        Ball = GetComponent<Rigidbody>();
        Debug.LogWarning("Awake successful" + Ball.ToString());
        speed = 100;
    }

    private void OnCollisionEnter()
    {
        grounded = true;
    }
    private void OnCollisionExit()
    {
        grounded = false;
    }

    public void FixedUpdate()
    {
        Debug.LogWarning("FixedUpdate started!");
        Vector3 Vector;
        float X;
        float Y;
        Y = Input.GetAxis("Vertical");
        X = Input.GetAxis("Horizontal");
        Vector = new Vector3(X, Y, 0);
        if(grounded)
        {
            Rool(Vector);
        }

        
     
    }
    public void Rool(Vector3 move)
    {
        Vector3 moveVector;
        moveVector = move * speed;
        Ball.AddForce(moveVector);

    }
    
   
    }

