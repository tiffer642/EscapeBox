using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public Scene previousScene;
    public string nameOfLastScene;
    public Scene currentScene;
    public string nameOfCurrentScene;

    public void LoadLevel()
    {
        previousScene = SceneManager.GetSceneByName(nameOfLastScene);
        currentScene = SceneManager.GetSceneByName(nameOfCurrentScene);
        SceneManager.LoadSceneAsync(nameOfLastScene);
    }
}
