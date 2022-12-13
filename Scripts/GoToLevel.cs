using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{
    public string level;

    public void LoadLevel()
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }
}
