using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSceneTri : MonoBehaviour {
    public GameObject cam;
    public AudioSource a;
    public AudioSource b;
    public GameObject camer;
    public GameObject Final;
    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.name == "Female")
        {
            a.Stop();
            b.Stop();
            other.gameObject.SetActive(false);
            camer.SetActive(false);
            //yield return new WaitForSeconds(.1f);
            cam.SetActive(true);
            Final.SetActive(true);
            yield return new WaitForSeconds(.1f);
        }
    }
}
