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
    public GameObject [] animalCatalog;
    public float spawnSpeed;

    void Start(){

        StartCoroutine(Example());

    }

    IEnumerator Example(){

        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);

    }

    // Update is called once per frame
    void Update(){
        if(transform.position.x > xRange || transform.position.x < -xRange ){
            direction = direction * -1;
        }
        
        transform.Translate(Vector3.right * Time.deltaTime * HorizontalSpeed * direction);
    }
}
