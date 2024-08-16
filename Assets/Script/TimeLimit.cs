using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{
    public int targetScore = 10;
    public float timeLimit = 300f;
    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverText;
    public GameObject MainMenu;

    private TMP_Text timerText;
    private float timeRemaining;

    void Start()
    {
        timerText = GetComponent<TMP_Text>();
        timeRemaining = timeLimit;
        gameOverPanel.SetActive(false);
        MainMenu.SetActive(false);
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;

        timerText.text = "Time: " + Mathf.Ceil(timeRemaining);

        if (ScoreManager.score >= targetScore)
        {
            GameOver(true);
        }

        if (timeRemaining <= 0f)
        {
            GameOver(false);
        }
    }

    void GameOver(bool won)
    {
        Time.timeScale = 0f;

        gameOverPanel.SetActive(true);
        MainMenu.SetActive(true);

		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

		if (won)
        {
            gameOverText.text = "You Win!";
        }
        else
        {
            gameOverText.text = "Game Over!";
        }
    }
}
