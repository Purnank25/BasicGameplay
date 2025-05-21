using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topbound = 30;
    private float lowerbound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topbound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerbound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject); 
        }
    }
}
