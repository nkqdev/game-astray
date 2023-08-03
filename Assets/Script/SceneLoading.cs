using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
}
