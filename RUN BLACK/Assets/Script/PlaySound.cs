using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {
    public AudioClip[] au;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void sound(int id) {
        GetComponent<AudioSource>().clip = au[id];
        GetComponent<AudioSource>().Play();
    }
}
