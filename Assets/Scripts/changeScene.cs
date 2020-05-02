using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public string SceneName;

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
