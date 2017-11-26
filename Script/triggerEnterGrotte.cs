using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerEnterGrotte : MonoBehaviour {
    public string scene;
    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.name == "Female")
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(scene);
        }
    }
}
