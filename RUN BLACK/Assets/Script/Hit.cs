using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Hit : MonoBehaviour
{
    int live = 100;
    int hit = 20;
    public Text l;
    //int a = 225;
    int a;
    public GameObject block;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        l.text = string.Format("{0}/100", live);
        a = GameObject.FindWithTag("Player").GetComponent<PlayerState>().hitobj;
        block.transform.localPosition = new Vector3(0 - a, 0, 0);
        if (live <= 0)
        {
            l.text = "0/100";
        }
    }

    void livem(int i)
    {
        if (i == 1)
        {
            live = live - hit;
        }
        else if(i == 2)
        {
            live -= 10;
        }

        if (live <= 0)
        {
            Application.LoadLevel("Time");
        }

    }
}
