using UnityEngine;

public class OscillatorMovement : MonoBehaviour
{
    public float horizontalRange = 25;
    public float verticalRange = 25;
    public float accelerationFactor = 1;
    private float speedFactor = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += new Vector3
            (horizontalRange / 10 * Mathf.Cos(speedFactor),
            verticalRange / 10 * (Mathf.Cos(speedFactor) * Mathf.Sin(speedFactor)),
            0);
        speedFactor += accelerationFactor / 1000;
        
    }
}
