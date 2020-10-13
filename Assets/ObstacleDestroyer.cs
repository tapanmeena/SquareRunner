using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    //private void OnBecameInvisible()
    //{
    //    Destroy(gameObject);
    //}
    //public Transform cam;
    //public void FixedUpdate()
    //{
    //    Debug.Log("---------------------- Some output    "+Camera.main.transform.position);
    //}
    public void FixedUpdate()
    {
//        Debug.Log("Position for " + this.gameObject.name + " positions  "+this.gameObject.transform.position);
        if (this.gameObject.transform.position.z + 10 < Camera.main.transform.position.z)
        {
            Debug.Log("Destroy this object " + this.gameObject.name);
            Destroy(this.gameObject);
        }

    }
}
