using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnObjectinspace : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public BoxCollider spawnArea;
    public int Life = 10;
    public TMP_Text lifeText;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Life != 0)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
                Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
                Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z)

            );
            Life--;
            Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
        }
        // ƒ‰ƒCƒt
        lifeText.text = "Life: " + Life.ToString();
    }
}