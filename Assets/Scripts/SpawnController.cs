using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{    
    //Range where the animals wil spawn
    private float xRange = 16f;

    //Attributes for spawn animals
    public GameObject[] animalCatalog;
    private float initDelay = 2f;
    private float  spawnIntervale = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnAnimals", initDelay, spawnIntervale);
    }

    // Update is called once per frame
    void Update(){
        
    }

    void SpawnAnimals(){
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 0, transform.position.z);    
        int indexAnimal = Random.Range(0, animalCatalog.Length);

        Instantiate(animalCatalog[indexAnimal], spawnPos, animalCatalog[indexAnimal].transform.rotation);
    }
}
