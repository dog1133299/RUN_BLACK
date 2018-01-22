using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class WaterAmount : MonoBehaviour
{
    float ETotal = 100;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float w = GameObject.FindWithTag("Player").GetComponent<PlayerState>().wnum;
        if (this.transform.localPosition.x <= 1)
        {
            this.transform.localPosition = new Vector3(-200 + 200 * (w / ETotal), 0, 0);
        }
    }

}
