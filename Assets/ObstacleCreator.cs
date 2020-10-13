using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    public Transform PlayerMovement;
    Vector3 offset = new Vector3(0, 0, 40);
    object[] Prefabs;
    Queue<GameObject> GameObjectsQueue = new Queue<GameObject>();

//    float initialLocation = -175f;
    float NextObstacleSpawnLocation = -175f + 17f, ObstacleDistance = 17f;

	private void Start()
	{
        Prefabs = Resources.LoadAll("Prefabs/Obstacles");
    }

    void FixedUpdate()
    {
        transform.position = PlayerMovement.position + offset;
        if(transform.position.z >= NextObstacleSpawnLocation)
        {
            NextObstacleSpawnLocation += ObstacleDistance;
            int index = Random.Range(0, Prefabs.Length);
            GameObject obj = Prefabs[index] as GameObject;
            GameObjectsQueue.Enqueue(obj);
            Vector3 SpawnLocation = GiveSpawnLocation(index+1, transform.position);
            Instantiate(obj, SpawnLocation, Quaternion.identity);
        }
    }

    Vector3 GiveSpawnLocation(int ObstacleNumber, Vector3 pos)
    {
        switch(ObstacleNumber)
		{
            case 1:
                return new Vector3(-3.668755f, 2.233833f, pos.z);
            case 2:
                return new Vector3(0.0149998f, 1f, pos.z);
            case 3:
                return new Vector3(-0.7440561f, 4.468444f, pos.z);
            case 4:
                return new Vector3(0f, 1f, pos.z);
            case 5:
                return new Vector3(Random.Range(-3.5f,3.5f), 1f, pos.z);

            default:
                return pos;
		}
    }
}
