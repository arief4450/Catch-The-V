using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
	public string splashScreenScene = "Splash Screen";
	public string coreGameScene = "Core Game";

	public void OnStartButtonPressed()
	{
		SplashScreen.SetTargetScene(coreGameScene);

		SceneManager.LoadScene(splashScreenScene);
	}

	public void OnQuitButtonPressed()
	{
		Application.Quit();
	#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
	#endif
	}
}
