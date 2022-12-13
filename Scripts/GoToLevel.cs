using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{
    public string destination;

    public void LoadLevel()
    {
        SceneManager.LoadScene(destination, LoadSceneMode.Single);
    }
}
