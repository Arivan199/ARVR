using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampoline : MonoBehaviour
{
    public float BouncingForce = 2f;
    public Rigidbody PlayerBall;

    private void Start()
    {
        GameObject.Find("ball").GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            PlayerBall.AddForce(Vector3.up * BouncingForce);
    }
}