using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playScene : MonoBehaviour {
    public AsyncOperation op;
    public string scene;
    public void ChangeLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
