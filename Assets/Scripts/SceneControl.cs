using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneControl : MonoBehaviour
{

    Scene currentScene;

    // Use this for initialization
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    // Reloads the scene with any variales reset to their default values.
    public void RestartScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Reloaded scene.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartScene(currentScene.name);
        }
    }
}