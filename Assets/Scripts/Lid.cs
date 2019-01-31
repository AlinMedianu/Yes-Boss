using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lid : MonoBehaviour
{

    public Rigidbody rb;
    void Start()
    {
        rb.velocity = Vector3.forward * Random.Range(2,15);
    }
}
