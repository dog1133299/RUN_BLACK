using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;


/// <summary>
/// Parallax scrolling script that should be assigned to a layer
/// </summary>
public class MapMove : MonoBehaviour
{
    public float minPositionX;
    public float terPositionX;
    public float s;
    private float temp;
    public Vector2 speed = new Vector2(2, 2);
    public static Vector2 speed1;
    public Vector2 direction = new Vector2(-1, 0);
    public bool isLinkedToCamera = false;
    public Transform t;

    void Start()
    {
    }
    void Update()
    {
        speed1 = speed;
        // Movement
        Vector3 movement = new Vector3(
            speed.x * direction.x,
            speed.y * direction.y,
            0);

        movement *= Time.deltaTime;
        transform.Translate(movement);
        terPositionX = t.position.x;
        
        // Move the camera
        if (isLinkedToCamera)
        {
            Camera.main.transform.Translate(movement);
        }
        if (transform.localPosition.x < minPositionX)
        {
            transform.localPosition = new Vector3(terPositionX + 23F, transform.localPosition.y, transform.localPosition.z);
        }
        s = GameObject.FindWithTag("Timer").GetComponent<Timer>().second;

    }

    void FixedUpdate()
    {

        if (s >= 20 && s % 20 == 0)
        {
            speed.x += 0.03F;
        }

    }
    void firefast(int i)
    {
        if (speed.x < 15 && Timer.m <= 1)
        {
            speed = new Vector2(speed.x + 1, 2);
        }
        else if (Timer.m > 1)
        {
            speed = new Vector2(speed.x + 1, 2);
        }
        
    }
    void dirtslow(int i)
    {
        if (Timer.m < 1)
        {
            speed = new Vector2(7, 2);
        }
        else if (Timer.m > 1 && speed.x > 12)
        {
            speed = new Vector2(speed.x -2, 2);
        }
    }
}