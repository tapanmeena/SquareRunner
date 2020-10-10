using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    float Delay = 3f;
    public Text ScoreText;
    public Text ShowCurrentScore;
    public GameObject GameoverPanel;
    public void ShowEndScreen()
    {
        Debug.Log("GAME OVER!!!!!!\n You Suck");
        Debug.Log("Score you got is " + ScoreText.text);
        ShowCurrentScore.text = ScoreText.text;
        Invoke("AddDelay", 2);
    }
    public void RestartLevel()//(string EndCondition)
    {
//        Debug.Log(EndCondition);
        Restart();
    }
    void AddDelay()
    {
        GameoverPanel.SetActive(true);
        Invoke(nameof(RestartLevel), Delay);
        Debug.Log("After 2 seconds");
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
