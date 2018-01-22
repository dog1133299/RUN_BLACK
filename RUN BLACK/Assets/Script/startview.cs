using UnityEngine;
using System.Collections;

public class startview : MonoBehaviour
{
    public GameObject load;
    public static int j;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void start()
    {
        PlayerPrefs.SetInt("status", 1);
        Application.LoadLevel("Scene1");   
        load.SetActive(true);
        

    }
    public void role()
    {
        Application.LoadLevel("MAIN");
        load.SetActive(true);
    }
    public void time()
    {       
        if (PlayerPrefs.GetInt("status",0) == 1)
        {
            PlayerPrefs.SetInt("status", 0);
            j = 1;
        }
        else if (PlayerPrefs.GetInt("status",0) == 0)
        {
            j = 0;
        }   
        Application.LoadLevel("LeaderBoard");
        load.SetActive(true);

    }
    public void exit()
    {
        PlayerPrefs.DeleteKey("status");
        Application.Quit();
    }
}
