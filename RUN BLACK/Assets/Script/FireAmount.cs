using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class FireAmount : MonoBehaviour
{
    float ETotal = 100;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float f = GameObject.FindWithTag("Player").GetComponent<PlayerState>().fnum;
        if (this.transform.localPosition.x <= 1)
        {
            this.transform.localPosition = new Vector3(-200 + 200 * (f / ETotal), 0, 0);
        }
    }

}
