using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    float Delay = 3f;
    public void ShowEndScreen()
    {
        Debug.Log("GAME OVER!!!!!!\n You Suck");
        Invoke(nameof(Restart), Delay);
    }
    public void RestartLevel()//(string EndCondition)
    {
//        Debug.Log(EndCondition);
        Restart();
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
