using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{
    public Rigidbody rb;
    float moveSpeed = 10f;
	void Start ()
    {
        rb.velocity = Vector3.forward * moveSpeed;
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Body")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            if (tag == "P1Pen")
                FindObjectOfType<GameManager>().p1Score++;
            else
                FindObjectOfType<GameManager>().p2Score++;
        }
    }
}
