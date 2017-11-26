using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThunderCloud : MonoBehaviour {
    public List<GameObject> CloudTog;
    public GameObject cloud;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnCloud", 4, 4);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        foreach (GameObject a in CloudTog)
        {
            float speed = Random.Range(1, 5);
            Vector3 rot = a.transform.eulerAngles;
            rot.x = 90;
            a.transform.eulerAngles = rot;
            a.transform.Translate(0, -speed, 0);
        }
    }
    public void SpawnCloud()
    {
        int[] step = { -50, 50 };
        int a = Random.Range(0, 2);
        GameObject Cloud;
        int xPos = Random.Range(-10000, 10000);
        int yPos = Random.Range(-20, 600);
        int zPos = Random.Range(-10, 4000);
        int Sca = Random.Range(1000,5000);
        Vector3 pos = new Vector3(transform.position.x + xPos + step[a], transform.position.y + yPos, transform.position.z + zPos + step[a]);
        Cloud = Instantiate(cloud, pos, Quaternion.identity) as GameObject;
        //Cloud.transform.SetPositionAndRotation(transform.position, new Quaternion(45, 0, 0, 0));
        Cloud.transform.localScale += new Vector3(Sca, Sca, Sca - 20);
        Cloud.SetActive(true);
        CloudTog.Add(Cloud);
    }
}
