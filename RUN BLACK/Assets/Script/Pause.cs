using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    public GameObject startbutton;
    public GameObject resumebutton;
    public GameObject exitbutton;
    public bool IsGamePaused;
    public GameObject load;
    public GameObject intr;
    public static bool intro;
    int i;

    void Start()
    {
        StartGame();
        intro = true;
    }

    void Update()
    {

    }
    public void onCLick() {
        i += 1;
        if (i % 2 != 0)
        {
            PauseGame();
            exitbutton.SetActive(true);
            startbutton.SetActive(true);
            resumebutton.SetActive(true);
            intr.SetActive(false);
            intro = false;
        }
        else if (i % 2 == 0)
        {
            StartGame();
            exitbutton.SetActive(false);
            startbutton.SetActive(false);
            resumebutton.SetActive(false);
            intr.SetActive(false);
            intro = true;
        }
    }
    public void Menu()
    {
        PlayerPrefs.SetInt("status", 0);
        Application.LoadLevel("start");
        load.SetActive(true);
    }
    public void Resume()
    {
        StartGame();
        exitbutton.SetActive(false);
        startbutton.SetActive(false);
        resumebutton.SetActive(false);
        intro = true;
    }
    public void Exit()
    {
        Application.Quit();
    }

    void StartGame()
    {
        IsGamePaused = false;
        Time.timeScale = 1;
    }

    void PauseGame()
    {
        IsGamePaused = true;
        Time.timeScale = 0;
    }
}