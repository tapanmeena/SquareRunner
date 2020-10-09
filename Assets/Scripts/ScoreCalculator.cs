using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    public Text ScoreText;
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Mathf.Floor(Time.time).ToString("0");
    }
}
