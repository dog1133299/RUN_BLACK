using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class DirtAmount : MonoBehaviour
{
    float ETotal = 100;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float d = GameObject.FindWithTag("Player").GetComponent<PlayerState>().dnum;
        if (this.transform.localPosition.x <= 1)
        {
            this.transform.localPosition = new Vector3(-200 + 200 * (d / ETotal), 0, 0);
        }
    }

}
