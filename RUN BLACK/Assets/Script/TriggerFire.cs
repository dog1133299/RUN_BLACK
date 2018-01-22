using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TriggerFire : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        Camera.main.SendMessage("sound", 1);
        Destroy(gameObject);
        if (hit.tag == "Player")
        {
            hit.gameObject.SendMessage("FireAmount", 1);
            GameObject.Find("score").SendMessage("scorecount", 2);
        }
    }
}
