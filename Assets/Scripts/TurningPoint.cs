using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent && other.transform.parent.parent == transform)
        {
            other.transform.Rotate(Vector3.down * 90);
            other.GetComponent<Rigidbody>().velocity = Vector3.back * transform.parent.parent.GetComponent<Pipe>().Force;
        }
    }
}
