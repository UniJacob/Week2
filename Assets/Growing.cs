using UnityEngine;

public class Growing : MonoBehaviour
{
    [SerializeField]
    public float growthRate = 1;
    public float growthScale = 10;
    private float sum = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(growthScale, growthScale, 0) * Mathf.Abs(Mathf.Cos(sum));
        sum += growthRate/1000;
    }
}
