using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController Instance;

    public static int Points { get; private set; }

    public static bool GameStarted { get; private set; }

    [SerializeField]
    private TextMeshProUGUI gameResult;
    [SerializeField]
    private TextMeshProUGUI pointsText;

    public GameObject buttonContinue;
    public bool isContinueGame;
    public Text text;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        gameResult.text = "";

        SetPoints(0);
        GameStarted = true;
        isContinueGame = false;

        Field.Instance.GenerateField();
    }

    public void Win()
    {
        GameStarted = false;
        gameResult.color = ColorManager.Instance.WinColor;
        gameResult.text = "You Win!";

        buttonContinue.SetActive(true);
    }

    public void Lose()
    {
        GameStarted = false;
        gameResult.color = ColorManager.Instance.LoseColor;
        gameResult.text = "You Lose!";       
    }

    public void AddPoints(int points)
    {
        SetPoints(Points + points);
    }

    public void SetPoints(int points)
    {
        Points = points;
        pointsText.text = Points.ToString();
    }

    public void ContinueGame()
    {
        GameStarted = true;
        isContinueGame = true;
        gameResult.text = "";
        buttonContinue.SetActive(false);
    }
}
