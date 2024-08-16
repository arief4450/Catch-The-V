using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public string defaultScene = "Core Game";
    public float delay = 2.0f;

    private static string targetScene;

    void Start()
    {
        if (string.IsNullOrEmpty(targetScene))
        {
            targetScene = defaultScene;
            Debug.Log("Target scene was null or empty, setting to default: " + defaultScene);
        }
        else
        {
            Debug.Log("Target scene is set to: " + targetScene);
        }

        StartCoroutine(TransitionToScene());
    }

    private IEnumerator TransitionToScene()
    {
        Debug.Log("Coroutine started, waiting for " + delay + " seconds.");
        yield return new WaitForSeconds(delay);

        Debug.Log("Loading target scene: " + targetScene);

        SceneManager.LoadScene(targetScene);

        targetScene = null;
    }

    public static void SetTargetScene(string sceneName)
    {
        targetScene = sceneName;
        Debug.Log("Set target scene to: " + sceneName);
    }
}
