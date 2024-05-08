using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjecSpone : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; 
    public int numberOfPrefabs = 10;    
    public BoxCollider spawnArea;      

    void Start()
    {

        for (int i = 0; i < numberOfPrefabs; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
                Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
                Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z)
            );

            GameObject prefabToSpawn = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)];
            Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
        }
    }
}