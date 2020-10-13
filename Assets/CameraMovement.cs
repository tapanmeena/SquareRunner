using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
            rb.AddForce(0, 0, 500f * Time.fixedDeltaTime);
        if (Input.GetKey("s"))
            rb.AddForce(0, 0, -500f * Time.fixedDeltaTime);

    }
}
