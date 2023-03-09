using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnRadius = 5f;
    public int minSpawnNumber = 1;
    public int maxSpawnNumber = 100;



    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {   
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObjects();
        }
    }

    public void SpawnObjects()
    {
        // Generate a random number of spheres to spawn
        int numSpheres = Random.Range(minSpawnNumber, maxSpawnNumber + 1);

        // Spawn each sphere
        for (int i = 0; i < numSpheres; i++)
        {
            // Generate a random position within the spawn radius
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;

            // Spawn the sphere prefab at the random position
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        }
    }

}
