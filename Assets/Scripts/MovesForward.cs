using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesForward : MonoBehaviour
{
    //Definition of the attributes
    public float speed = 15f;
    private float limit = 15f; 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        if(transform.position.z > limit || transform.position.z < -limit){
            Destroy(gameObject);
        }
    }
}
