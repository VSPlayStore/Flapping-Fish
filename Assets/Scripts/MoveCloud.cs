using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
