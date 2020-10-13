using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TryObstacleGeneration : MonoBehaviour
{
	float SpawnDelay = 5f, SpawnTime = 0f, DestroyTime = 12f, DestroyDelay = 5f;
	object[] Prefabs;
	Queue<GameObject> GameObjectsQueue = new Queue<GameObject>();
	int numberOfObstaclesToSpawn = 1;
	// Start is called before the first frame update
	void Start()
	{
		Prefabs = Resources.LoadAll("Prefabs/Obstacles");

		//Debug.Log(Prefabs.Length);
		//foreach (object obj in data)
		//{
		//    Debug.Log(obj);
		//    Vector3 v = transform.position;
		//    GameObject go = obj as GameObject;
		//    Instantiate(go, v, Quaternion.identity);
		//}
		//GameObject obj;
		//        Debug.Log(data.Length + " Assets");
		//foreach (string o in data)
		//{
		//    Debug.Log("assets " + o);
		//    if (o.Contains("Resources/Prefabs/"))
		//    {
		//        Debug.Log("asd " + o);
		//    }
		//}
		//GameObject obj = Resources.Load("Assets/Resources/Prefabs/SquareObstacle.prefab") as GameObject;
		//Debug.Log(obj);
		//Vector3 v = transform.position;
		//Instantiate(obj, v, Quaternion.identity);
		//        Instantiate(obj,);
	}

	// Update is called once per frame
	void Update()
	{
		if(Time.time >= SpawnTime )
		{
			SpawnObstacle();
		}
		if(Time.time >= DestroyTime)
		{
			DestroyObstacle();
		}
	}

	void DestroyObstacle()
	{
//		DestroyTime = Time.time + DestroyDelay;
//		Debug.Log("Before Top of the Queue "+GameObjectsQueue.Peek());
//		Destroy(GameObjectsQueue.Peek());
////        DestroyImmediate(GameObjectsQueue.Peek(),true);
//		GameObjectsQueue.Dequeue();
//		Debug.Log("After Top of the Queue "+GameObjectsQueue.Peek());
	}
	void SpawnObstacle()
	{
		for(int i=0;i<numberOfObstaclesToSpawn;i++)
        {
			SpawnTime = Time.time + SpawnDelay;
			int index = Random.Range(0, Prefabs.Length);
			GameObject obj = Prefabs[index] as GameObject;
			GameObjectsQueue.Enqueue(obj);
			Vector3 SpawnLocation = transform.position;
			SpawnLocation.y = 3;
			Instantiate(obj, SpawnLocation, Quaternion.identity);
		}
		//Debug.Log("Queue Size " + GameObjectsQueue.Count);
	}
}
