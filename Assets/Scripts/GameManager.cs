using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public bool GameStart { get; private set; }

    public bool GameOver { get; private set; }

    UnityEvent gameHasStarted;
    UnityEvent gameHasEnded;
    // Start is called before the first frame update
    void Awake()
    {
        GameStart = false;
        GameOver = false;
        gameHasStarted = new UnityEvent();
        gameHasEnded = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameStart && Input.GetMouseButtonDown(0))
        {
            GameStart = true;
            gameHasStarted.Invoke();
        }

    }

    public void AddEventToGameStart(UnityAction action)
    {
        gameHasStarted.AddListener(action);
    }

    public void AddEventToGameEnd(UnityAction action)
    {
        gameHasEnded.AddListener(action);
    }

    public void GameEnds()
    {
        gameHasEnded.Invoke();
    }
}
