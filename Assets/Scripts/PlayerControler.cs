using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    //Definition of the attributes
    private float horizontalInput;
    public GameObject proyectilePrefab;
    private float HorizontalSpeed = 18f;

    //Range where the player can moves
    private float xRange = 18f;

    // Update is called once per frame
    private void Update(){
        
        //keep the payer is in the gaem area
        if(transform.position.x < -xRange )
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        } 

        if(transform.position.x > xRange )
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }  

        //Launch an proyectile
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectilePrefab, transform.position + new Vector3(0, 1.5f, 1f), proyectilePrefab.transform.rotation);
        }
    
        horizontalInput = Input.GetAxis("Horizontal");  // asigment of a value when the keys are pressed

        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * HorizontalSpeed); //Moves the player
    }
}
