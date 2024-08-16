using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoreGameManager : MonoBehaviour
{
	public string splashScreenScene = "Splash Screen";
	public string mainMenuScene = "Main Menu";

	public void OnMainMenuButtonPressed()
	{
		//SplashScreen.SetTargetScene(mainMenuScene);
		
		//SceneManager.LoadScene(splashScreenScene);

        SceneManager.LoadScene(mainMenuScene);
    }
}
