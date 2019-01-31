using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {


    float moveSpeed;
    public Rigidbody rb;
    public GameObject pen;
    public GameObject lid;
    public AudioClip penUncapped;
    private AudioSource audioSource;

    bool okToShoot = true;

    void Start()
    {
        moveSpeed = 5f;
        //load sfx
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector3.left * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector3.right * moveSpeed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.Space) && okToShoot)
        {
            StartCoroutine(WaitToShoot());
            //pen sound 
            audioSource.clip = penUncapped;
            audioSource.Play();
            Instantiate(pen, rb.position, Quaternion.identity);
            Instantiate(lid, new Vector3(transform.position.x, transform.position.y, transform.position.z+2), Quaternion.Euler(Random.Range(0,360), Random.Range(0, 360), Random.Range(0, 360)));
        }
    }
    IEnumerator WaitToShoot()
    {
        okToShoot = false;
        yield return new WaitForSeconds(0.5f);
        okToShoot = true;
    }
}
