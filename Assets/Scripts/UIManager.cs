using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject gameStartPanel;
    [SerializeField] GameObject gameEndPanel;

    // Update is called once per frame
    void Start()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        gm.AddEventToGameStart(DisableStartMenu);
        gm.AddEventToGameEnd(EnableEndMenu);
    }

    void EnableEndMenu()
    {
        gameEndPanel.SetActive(true);
        FindObjectOfType<ScoreManager>().EndGame();
    }

    void DisableStartMenu()
    {
        gameStartPanel.SetActive(false);
    }
}
