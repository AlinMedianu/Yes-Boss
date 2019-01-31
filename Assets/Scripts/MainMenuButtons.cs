using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public GameObject controls;
    public GameObject mainmenu;
    private void Start()
    {
        mainmenu.SetActive(true);
        controls.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
        mainmenu.SetActive(false);
    }
    public void EndGame()
    {
        Application.Quit();
    }
    public void Controls()
    {
        mainmenu.SetActive(false);
        controls.SetActive(true);
    }
    public void Back()
    {
        mainmenu.SetActive(true);
        controls.SetActive(false);
    }

}
