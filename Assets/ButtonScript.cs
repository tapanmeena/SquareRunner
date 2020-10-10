using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void OnButtonPress()
    {
        FindObjectOfType<GameManager>().RestartLevel();
    }
}
