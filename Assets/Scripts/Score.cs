using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI HighScore;
    int myScore = 0;
    void Start()
    {
        HighScore.text = "Highest Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    void Update()
    {
        scoreText.text = myScore.ToString();
        finalScoreText.text = "Score: " + myScore.ToString();
        if(myScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", myScore);
            HighScore.text = "Highest Score: " + myScore.ToString();
        }
    }
    
    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}