using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    public Text ScoreText;
    // Update is called once per frame
    float StartTime;
    private void Start()
    {
        StartTime = Time.time;
    }
    void Update()
    {
        ScoreText.text = Mathf.Floor(Time.time - StartTime).ToString();
    }
}
