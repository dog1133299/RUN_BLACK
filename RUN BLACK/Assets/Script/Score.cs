using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Score : MonoBehaviour {
    int point = 0;
    public static int send;
    public Text sc;
    private string s;
	// Use this for initialization
	void Start () {
        s = "0000000";
	}
	
	// Update is called once per frame
	void Update () {
        sc.text = s;
        send = point;
	}
    void scorecount(int i)
    {
        if(i == 1){
            point -= 300;
        }
        else if (i == 2)
        {
            point += 50;
        }
        else if (i == 3)
        {
            point += 500;
        }
        else if (i == 4)
        {
            point += 1;
        }
        s = string.Format("{0:D7}", point);
        if (point < 0)
        {
            s = "0000000";
            point = 0;
        }
    }
}
