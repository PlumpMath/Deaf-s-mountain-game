using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyClood : MonoBehaviour {
    public Cloud_spawn CSM;
    public void Start()
    {
        CSM = FindObjectOfType<Cloud_spawn>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "cloud(Clone)")
        {
            CSM.CloudTog.Remove(other.gameObject);
            Destroy(other.gameObject);
            Debug.Log("UN NUAGE");
        }
    }
}
