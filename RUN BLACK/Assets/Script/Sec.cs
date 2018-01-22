using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Sec : MonoBehaviour {
    public Text secLabel;
    float[] array;
    int s;
    public static string secText;
    public static int send;
    int i;
	// Use this for initialization
	void Start () {
        
	}
	// Update is called once per frame
	void Update () {
        s = Score.send;
        secLabel.text = string.Format("{0}", s);
        send = s;
	}
}
