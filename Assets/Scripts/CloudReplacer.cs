using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudReplacer : MonoBehaviour
{
    public float timeInterval;
    private float timer;
    public GameObject cloud;
    public float height;

    void Update()
    {
        if (timer > timeInterval)
        {
            GameObject newCloud = Instantiate(cloud);
            newCloud.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newCloud, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
