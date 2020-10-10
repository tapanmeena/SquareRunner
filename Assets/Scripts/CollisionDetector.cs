using System.Collections;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
	public PlayerMovement movement;
	public Transform PlayerPosition;
	bool IsGameEnded = false;
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.name != "Ground" && collision.collider.name != name)
			IssueGameEnd("Collided With Obstacle " + collision.collider.name);
	}
	private void FixedUpdate()
	{
		if (PlayerPosition.position.y < -1f && !IsGameEnded)
			IssueGameEnd("Fall from the ground");
	}
	void IssueGameEnd(string HowGameEnd)
    {
//		Debug.Log(HowGameEnd);
		movement.enabled = false;
		FindObjectOfType<ScoreCalculator>().enabled = false;
		FindObjectOfType<GameManager>().ShowEndScreen();
		IsGameEnded = true;
	}
}
