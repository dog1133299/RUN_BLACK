using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ChangeScene : MonoBehaviour {
    public float m;
    public float s;
    public SpriteRenderer r1;
    public SpriteRenderer r2;
    public Sprite fire1;
    public Sprite fire2;
    public Sprite dirt1;
    public Sprite dirt2;
    public Sprite sea1;
    public Sprite sea2;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        m = GameObject.FindWithTag("Timer").GetComponent<Timer>().minute;
        s = GameObject.FindWithTag("Timer").GetComponent<Timer>().second;
        if (r1.transform.position.x < -21 && m % 3 == 1)
        {
            r1.sprite = fire1;
        }
        if (r2.transform.position.x < -21 && m % 3 == 1)
        {
            r2.sprite = fire2;
        }
        if (r1.transform.position.x < -21 && m % 3 == 2)
        {
            r1.sprite = dirt1;
        }
        if (r2.transform.position.x < -21 && m % 3 == 2)
        {
            r2.sprite = dirt2;
        }
        if (r1.transform.position.x < -21 && m % 3 == 0)
        {
            r1.sprite = sea1;
        }
        if (r2.transform.position.x < -21 && m % 3 == 0)
        {
            r2.sprite = sea2;
        }
	}
    void change()
    {
        /*if (m == 0)
        {
            firescene.SetActive(false);
        }*/

    }
}
