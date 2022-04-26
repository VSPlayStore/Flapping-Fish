using UnityEngine;

public class MovePipes : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
