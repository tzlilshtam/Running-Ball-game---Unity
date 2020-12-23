
using UnityEngine;

public class Moving_cube : MonoBehaviour
{
    [SerializeField]
    float delta;  // Amount to move left and right from the start point
    [SerializeField]
    float speed;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
