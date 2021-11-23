using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isup = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    private float move = 0.1f;
    private float temp = 2;

    void Update()
    {
        if (transform.position.x > 5.45 && transform.position.x < 7.56 && transform.position.z < 2.22 && transform.position.z > 0.25)
        {
            if (isup)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + move, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - move, transform.position.z);
            }
        }

        if (transform.position.y <= 0.1 )
        {
            isup = true;
            temp = temp + move;
        }
        else if(transform.position.y >= temp)
        {
            isup = false;
        }
    }
}
