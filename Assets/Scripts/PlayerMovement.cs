using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    float ForwardForce = 500f;
    float SidewardForce = 30f;
    bool MoveLeft = false, MoveRight = false;

    public GameManager gm;
    void FixedUpdate()
    {
//        Debug.Log(Mathf.Floor(Time.time));
        if(Input.GetKey("w"))
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if(MoveLeft)
        {
            rb.AddForce( - SidewardForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
            MoveLeft = false;
        }
        if(MoveRight)
        {
            rb.AddForce(SidewardForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
            MoveRight = false;
        }
        if(Input.GetKey("r"))
        {
            gm.RestartLevel();  
        }
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (x < 0)
            MoveLeft = true;
        if (x > 0)
            MoveRight = true;
    }
}
