using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnelRespawner : MonoBehaviour
{
    [SerializeField]
    private float respawnRate;
    private float leftTimer;
    private float rightTimer;
    void Update ()
    {
        if(!transform.Find("FirstLeft").gameObject.activeSelf && !transform.Find("SecondLeft").gameObject.activeSelf && !transform.Find("ThirdLeft").gameObject.activeSelf)
        {
            GameObject.Find("Boss").GetComponent<bossHealth>().ImmuneToP1 = false;
            leftTimer += Time.deltaTime;
            if (leftTimer > respawnRate)
            {
                transform.Find("FirstLeft").gameObject.SetActive(true);
                transform.Find("SecondLeft").gameObject.SetActive(true);
                transform.Find("ThirdLeft").gameObject.SetActive(true);
                transform.Find("FirstLeft").GetComponent<Funnel>().Health = 3;
                transform.Find("SecondLeft").GetComponent<Funnel>().Health = 3;
                transform.Find("ThirdLeft").GetComponent<Funnel>().Health = 3;
                transform.root.Find("Turning Points").Find(transform.Find("FirstLeft").gameObject.name).gameObject.SetActive(true);
                transform.root.Find("Turning Points").Find(transform.Find("SecondLeft").gameObject.name).gameObject.SetActive(true);
                transform.root.Find("Turning Points").Find(transform.Find("ThirdLeft").gameObject.name).gameObject.SetActive(true);
                leftTimer = 0;
                GameObject.Find("Boss").GetComponent<bossHealth>().ImmuneToP1 = true;
            }
        }
        if (!transform.Find("FirstRight").gameObject.activeSelf && !transform.Find("SecondRight").gameObject.activeSelf && !transform.Find("ThirdRight").gameObject.activeSelf)
        {
            GameObject.Find("Boss").GetComponent<bossHealth>().ImmuneToP2 = false;
            rightTimer += Time.deltaTime;
            if (rightTimer > respawnRate)
            {
                transform.Find("FirstRight").gameObject.SetActive(true);
                transform.Find("SecondRight").gameObject.SetActive(true);
                transform.Find("ThirdRight").gameObject.SetActive(true);
                transform.Find("FirstRight").GetComponent<Funnel>().Health = 3;
                transform.Find("SecondRight").GetComponent<Funnel>().Health = 3;
                transform.Find("ThirdRight").GetComponent<Funnel>().Health = 3;
                transform.root.Find("Turning Points").Find(transform.Find("FirstRight").gameObject.name).gameObject.SetActive(true);
                transform.root.Find("Turning Points").Find(transform.Find("SecondRight").gameObject.name).gameObject.SetActive(true);
                transform.root.Find("Turning Points").Find(transform.Find("ThirdRight").gameObject.name).gameObject.SetActive(true);
                rightTimer = 0;
                GameObject.Find("Boss").GetComponent<bossHealth>().ImmuneToP2 = false;
            }
        }
    }
}
