using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gm;

    float ForwardForce = 1500f, SidewardForce = 40f;
    bool MoveLeft = false, MoveRight = false;

    void FixedUpdate()
    {
//        Debug.Log(Mathf.Floor(Time.time));
        if(Input.GetAxis("Vertical") > 0)
        rb.AddForce(0, 0, ForwardForce * Time.fixedDeltaTime);
        if(MoveLeft)
        {
            rb.AddForce( - SidewardForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            MoveLeft = false;
        }
        if(MoveRight)
        {
            rb.AddForce(SidewardForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            MoveRight = false;
        }
        if(Input.GetKey("r"))
            gm.RestartLevel();
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
