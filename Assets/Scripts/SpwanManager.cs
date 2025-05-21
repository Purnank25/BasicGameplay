using UnityEngine;
using UnityEngine.UIElements;

public class SpwanManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spwanRangeX = 20;
    public float spwanRangeZ = 20;
    private float startDelay = 2;
    private float spwanInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpwanRandomAnimal", startDelay, spwanInterval);
    }

    // Update is called once per frame
    void Update()
    {
        SpwanRandomAnimal();
    }
    void SpwanRandomAnimal()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spwanPos = new Vector3(Random.Range(-spwanRangeX, spwanRangeX), 0, spwanRangeZ);
            Instantiate(animalPrefabs[animalIndex], spwanPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
