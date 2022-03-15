using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConfig : MonoBehaviour
{
    public string sceneName;

    public void MoveScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
