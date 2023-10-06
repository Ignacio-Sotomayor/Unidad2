using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    //Definition of the attributes
    public float HorizontalSpeed;
    
    //Range where the spawner can moves
    private float xRange =12f;
    private float direction = 1;

    //Attributes for spawn animals
    public GameObject[] animalCatalog;

    public float spawnSpeed;

    void Start()
    {


    }

    IEnumerator Example()
    {
        
        
        
        yield return new WaitForSeconds(5);
        Debug.Log( 2 );

    }

    // Update is called once per frame
    void Update(){
        
        if(transform.position.x > xRange || transform.position.x < -xRange ){
            direction = direction * -1;
        }

        
        if(Input.GetKeyDown(KeyCode.S))
        {
            
            Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 0, transform.position.z);
            
            int indexAnimal = Random.Range(0, animalCatalog.Length);

            Instantiate(animalCatalog[indexAnimal], spawnPos, animalCatalog[indexAnimal].transform.rotation);
        }
        
        

        transform.Translate(Vector3.right * Time.deltaTime * HorizontalSpeed * direction);
    }
}
