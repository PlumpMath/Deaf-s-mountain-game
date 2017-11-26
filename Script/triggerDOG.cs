using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDOG : MonoBehaviour {
    public GameObject dogDialogue;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Female")
        {
            dogDialogue.SetActive(true);
        }
    }
}
