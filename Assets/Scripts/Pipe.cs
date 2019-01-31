using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField]
    private float force;
    [SerializeField]
    private float spawnRate;
    [SerializeField]
    private Transform paperPrefab;
    private int noPapers;
    private float timer;
    public float Force
    {
        get
        {
            return force;
        }
    }

    private void Start()
    {
        noPapers = 0;
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            Spawn();
            timer = 0;
        }
    }

    private void Spawn()
    {
        TurningPosition turningPosition = (TurningPosition)Random.Range(0, 6);
        Transform paper = Instantiate(paperPrefab, transform.position, transform.rotation, 
            transform.Find("Turning Points").Find(turningPosition.ToString()));
        paper.Find("Body").GetComponent<Rigidbody>().velocity = Vector3.left * force;
        paper.name = "Paper " + noPapers;
        ++noPapers;
    }
}
public enum TurningPosition { FirstLeft, SecondLeft, ThirdLeft, FirstRight, SecondRight, ThirdRight}
