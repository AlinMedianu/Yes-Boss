using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funnel : MonoBehaviour
{
    [SerializeField]
    private int health;

    public int Health
    {
        private get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    private void Update()
    {
        if (Health == 0)
        {
            gameObject.SetActive(false);
            transform.root.Find("Turning Points").Find(gameObject.name).gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1Pen" || other.tag == "P2Pen")
        {
            Destroy(other.gameObject);
            if(Health > 0)
                Health--;
        }
    }
}
