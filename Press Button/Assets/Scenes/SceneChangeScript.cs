using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    public string sceneName;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
