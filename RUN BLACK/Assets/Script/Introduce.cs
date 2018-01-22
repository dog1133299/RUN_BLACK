using UnityEngine;
using System.Collections;

public class Introduce : MonoBehaviour {
    public GameObject intr;
    public bool IsGamePaused;
    int i;
    bool a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnClick()
    {
        if (Pause.intro == true)
        {
            i += 1;
            if (i % 2 != 0)
            {
                intr.SetActive(true);
                PauseGame();
            }
            else if (i % 2 == 0)
            {
                intr.SetActive(false);
                StartGame();
            }
        }
        

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
