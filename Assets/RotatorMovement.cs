using UnityEngine;

public class RotatorMovement : MonoBehaviour
{
    public float speed = 1;
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        transform.RotateAround(target.position, Vector3.forward, speed * Time.deltaTime);
    }
}
