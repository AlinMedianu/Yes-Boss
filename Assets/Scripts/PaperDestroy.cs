using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperDestroy : MonoBehaviour
{
    GameObject gameManager;
    public GameObject middleGround;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Paper")
        {
            if (gameObject.transform.position.x > other.transform.position.x)
            {
                gameManager.GetComponent<GameManager>().P1TakeScore();
            }
            else
            {
                gameManager.GetComponent<GameManager>().P2TakeScore();
            }
        }
    }
}
