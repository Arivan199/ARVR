using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float move = 0.01f;
    void Update()
    {
        if (transform.position.x > -16 && transform.position.x < -14.8 && transform.position.z > 11 && transform.position.z < 15.5 && transform.position.y > 0 && transform.position.y < 2) 
        {
            transform.position = new Vector3(transform.position.x + move , transform.position.y,transform.position.z );
        }
        else
        {
            
        }
    }
}
