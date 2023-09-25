using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    private int score = 0;

    // Start is called before the first frame update
    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "Score:" + score;
    }

    public void EndGame()
    {
        FindObjectOfType<EndGameUI>().ShowScores(score);
    }
}
