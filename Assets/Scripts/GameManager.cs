using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text player1;
    public Text player2;
    public int p1Score = 20;
    public int p2Score = 20;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            player1.text = "" + p1Score;
            player2.text = "" + p2Score;
        }
        if(p1Score <= 0 || p2Score <= 0)
        {
            SceneManager.LoadScene("main");
        }
    }
    public void P1AddScore()
    {
        p1Score++;
    }
    public void P1TakeScore()
    {
        p1Score--;
    }
    public void P2AddScore()
    {
        p2Score++;
    }
    public void P2TakeScore()
    {
        p2Score--;
    }
}
