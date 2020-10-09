using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
	public PlayerMovement movement;
	public Transform PlayerPosition;
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.name != "Ground")
		{
			movement.enabled = false;
			FindObjectOfType<GameManager>().ShowEndScreen();
		}
	}
	private void FixedUpdate()
	{
		if (PlayerPosition.position.y < -1f)
        {
			movement.enabled = false;
			FindObjectOfType<GameManager>().ShowEndScreen();
		}
	}
}
