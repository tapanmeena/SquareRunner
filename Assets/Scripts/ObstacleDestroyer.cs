using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
	void FixedUpdate()
	{
		if (this.gameObject.transform.position.z + 20 < Camera.main.transform.position.z)
		{
//			Debug.Log("Destroyed this object " + this.gameObject.name);
			Destroy(this.gameObject);
		}
	}
}
