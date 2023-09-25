using TMPro;
using UnityEngine;

public class EndGameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highscoreText;

    private int score = 0;
    public void ShowScores(int score)
    {
        scoreText.text = "Score:" + score;
        if(PlayerPrefs.HasKey("highScore"))
        {
            int highScore = PlayerPrefs.GetInt("highScore");
            if(score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("highScore", score);
            }
            highscoreText.text = "High Score:" + highScore;
        } else
        {
            highscoreText.text = "High Score:" + score;
            PlayerPrefs.SetInt("highScore", score);
        }
    }
}
