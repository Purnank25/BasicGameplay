using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spwanRangeX = 20;
    public float spwanRangeZ = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spwanPos = new Vector3(Random.Range(-spwanRangeX, spwanRangeX), 0, spwanRangeZ);
            Instantiate(animalPrefabs[animalIndex], spwanPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
