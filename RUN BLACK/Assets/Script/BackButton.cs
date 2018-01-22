using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {
    public GameObject ld;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void onClick()
    {
        Application.LoadLevel("start");
    }
    public void LBoard()
    {
        Application.LoadLevel("LeaderBoard");
    }
    public void Album()
    {
        Application.LoadLevel("MAIN");
        ld.SetActive(true);
    }
}
