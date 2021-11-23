using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pull : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private float move = 0.01f;
    void Update()
    {
        if (transform.position.y < 1.85)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y + move, transform.position.z);
        }
        else
        {

        }
    }
}
