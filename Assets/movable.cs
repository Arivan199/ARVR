using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movable : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject testcube;
    Vector3 target = new Vector3(-14.57f,0.08f,12.03f);
    float speed = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Transform testcubePOS = testcube.GetComponent<Transform>();

        
        
            // a rigidbody tagged as "Ball" hit the player
            
            testcubePOS.position = Vector3.MoveTowards(testcubePOS.position, target, Time.deltaTime * speed);
        
    }
}
