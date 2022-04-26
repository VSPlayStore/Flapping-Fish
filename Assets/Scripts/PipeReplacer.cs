using UnityEngine;

public class PipeReplacer : MonoBehaviour
{
    public float timeInterval;
    private float timer;
    public GameObject pipe;
    public float height;

    void Update()
    {
        if (timer > timeInterval)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
