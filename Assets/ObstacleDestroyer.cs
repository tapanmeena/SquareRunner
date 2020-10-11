using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    float StartTime ;
    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 12f)
        {
            Destroy(gameObject);
        }
    }
}
