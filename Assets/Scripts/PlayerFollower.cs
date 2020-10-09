using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform PlayerMovement;

    public Vector3 offset;
    private void FixedUpdate()
    {
        transform.position = PlayerMovement.position + offset;
    }
}
