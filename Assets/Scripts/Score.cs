using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int highScore = 0;
    public Text highScoreText;
    public Text scoreText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 0;
        }
    }

    private void Update()
    {
        scoreText.text = "Score : " + score.ToString();
        highScoreText.text = "High Score : " + highScore.ToString();
        SaveHighScore();
    }

    private void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }
}
