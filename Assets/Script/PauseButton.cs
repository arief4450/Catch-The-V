using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
	public GameObject pauseMenu; 
	private bool isPaused = false; 

	void Start()
	{
		pauseMenu.SetActive(false);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (isPaused)
			{
				ResumeGame();
			}
			else
			{
				PauseGame();
			}
		}
	}

	public void PauseGame()
	{
		Time.timeScale = 0f;
		isPaused = true;
		pauseMenu.SetActive(true);
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void ResumeGame()
	{
		Time.timeScale = 1f;
		isPaused = false;
		pauseMenu.SetActive(false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	public void OnResumeButtonPressed()
	{
		ResumeGame();
	}
}
