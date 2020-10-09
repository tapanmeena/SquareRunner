using UnityEngine;

public class EndlessGround : MonoBehaviour
{
    public Transform PlayerPosition;

    private void FixedUpdate()
    {
        if(PlayerPosition.position.z + 200 >= transform.localScale.z/2)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z * 2);
            Debug.Log("Ground Increased");
        }
    }

}
