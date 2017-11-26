using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caveTrigg : MonoBehaviour {
    public GameObject dialogue;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Female")
        {
            dialogue.SetActive(true);
        }
        
    }
}
