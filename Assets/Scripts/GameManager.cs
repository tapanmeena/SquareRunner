using System.Collections;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
//    float Delay = 3f;
    public Text ScoreText, ShowCurrentScore, HighscoreText;
    public GameObject GameoverPanel;
    public GameObject obstacle;
    readonly float slowness = 10f;
    public void ShowEndScreen()
    {
        Debug.Log("GAME OVER!!!!!!\n You Suck");
        ShowCurrentScore.text = ScoreText.text;
        HighscoreUpdater();
        StartCoroutine(AddCoolEffect());
//        AddDelay();
        Invoke(nameof(AddDelay), 2);
    }

    IEnumerator AddCoolEffect()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime /=  slowness;

        yield return new WaitForSeconds(1f/slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime *= slowness;
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
