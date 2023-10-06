using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    private float limit = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                
        if(transform.position.z > limit )
        {
            Destroy(gameObject);
        }else if(transform.position.z < -limit)
        {
            Debug.Log("Game Over!!!");
            Destroy(gameObject);
        }
    }
}
