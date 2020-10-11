using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
//    float Delay = 3f;
    public Text ScoreText, ShowCurrentScore, HighscoreText;
    public GameObject GameoverPanel;
    public GameObject obstacle;
    public void ShowEndScreen()
    {
        Debug.Log("GAME OVER!!!!!!\n You Suck");
        ShowCurrentScore.text = ScoreText.text;
        HighscoreUpdater();
        Invoke("AddDelay", 2);
    }

    void HighscoreUpdater()
    {
        if (float.Parse(ScoreText.text) > PlayerPrefs.GetInt("highscore",0))
        {
            HighscoreText.text = ScoreText.text;
            PlayerPrefs.SetInt("highscore", int.Parse(HighscoreText.text));
        }
    }
    private void Start()
    {
        //        Debug.Log(obstacle.transform);
        //        Instantiate(obstacle);

        HighscoreText.text = PlayerPrefs.GetInt("highscore",0).ToString();
    }
    public void RestartLevel()
    {
        Restart();
    }
    void AddDelay()
    {
        GameoverPanel.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RetrnToMenuScreen()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    //public void RandomObstacleGeneration()
    //{

    //}
}
