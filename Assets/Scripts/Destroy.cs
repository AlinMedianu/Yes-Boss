using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]
    private float destructionTime;
    private void Start()
    {
        Destroy(gameObject, destructionTime);
    }
}
