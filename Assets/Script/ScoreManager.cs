using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
	public static int score = 0;
	private TMP_Text scoreText;

	private void Start()
	{
		scoreText = GetComponent<TMP_Text>();
	}
	void Update()
	{
		scoreText.text = "Score: " + score;
	}

	public static void AddScore(int points)
	{
		score += points;
	}
}
