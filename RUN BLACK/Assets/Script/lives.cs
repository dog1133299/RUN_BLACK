using UnityEngine;
using System.Collections;

public class lives : MonoBehaviour {
    string a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnTriggerEnter2D(Collider2D hit)
    {
        a = GameObject.FindWithTag("Player").GetComponent<PlayerState>().wa;
        GameObject.FindWithTag("Player").SendMessage("sound", 2);

        if (this.tag == "ob1")
        {
            GetComponent<Animator>().Play("hit1");
        }
        else if (this.tag == "ob2")
        {
            GetComponent<Animator>().Play("hit3");
        }
        
        if (hit.tag == "Player")
        {
            GameObject.Find("score").SendMessage("scorecount", 1);
            if (a != "water")
            {
                GameObject.Find("livepoint").SendMessage("livem", 1);
                hit.gameObject.SendMessage("Hit", 90);
            }else if (a == "water")
            {
                GameObject.Find("livepoint").SendMessage("livem", 2);
                hit.gameObject.SendMessage("Hit", 45);
            }
            
        }
    }
}
