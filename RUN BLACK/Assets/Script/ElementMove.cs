using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;



public class ElementMove : MonoBehaviour {

    public float speed;
    private float movespeed;
    public float minPositionX;
    public float s;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 5f);
        

    }
    // Update is called once per frame
    void Update()
    {
        movespeed = speed * Time.deltaTime;
        transform.Translate(Vector3.left * movespeed, Space.World); //向左移動
        speed = MapMove.speed1.x;
        s = GameObject.FindWithTag("Timer").GetComponent<Timer>().second;
    }
    void FixedUpdate()
    {

        while (s >= 20 && s % 20 == 0)
        {
            speed += 0.03F;
            break;
        }
    }
}
