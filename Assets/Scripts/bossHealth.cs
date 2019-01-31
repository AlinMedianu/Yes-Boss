using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class bossHealth : MonoBehaviour
{
    bool doOnce;
    [SerializeField]
    private int health;
    public Slider healthbar;
    GameObject gameManager;

    public bool ImmuneToP1 { private get; set; }
    public bool ImmuneToP2 { private get; set; }


    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        ImmuneToP1 = true;
        ImmuneToP2 = true;
        doOnce = true;
    }
    private void Update()
    {
        healthbar.value = health;
        if(doOnce && health == 0)
        {
            SceneManager.LoadScene("WinLoose", LoadSceneMode.Single);
            doOnce = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if(other.gameObject.tag == "P1Pen")
        {
            if(!ImmuneToP1)
                health -= 5;
            gameManager.GetComponent<GameManager>().P1AddScore();
        }
        if(other.gameObject.tag == "P2Pen")
        {
            if (!ImmuneToP2)
                health -= 5;
            gameManager.GetComponent<GameManager>().P2AddScore();
        }
    }
}
