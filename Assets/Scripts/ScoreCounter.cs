using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        if(Score.highScore <= Score.score)
        {
            Score.highScore = Score.score;
        }
    }
}
