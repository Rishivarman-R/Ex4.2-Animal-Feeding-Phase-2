using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public float spawnRangeX = 8;
    public float spawnPosZ = -2;
    public float startDelay = 5;
    public float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAnimal()
    {
       int animalIndex = Random.Range(0, animalPrefab.Length);
       Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
       Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }
}