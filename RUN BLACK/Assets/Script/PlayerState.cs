using UnityEngine;
using System.Collections;



public class PlayerState : MonoBehaviour {
    public int wnum = 0;
    public int fnum = 0;
    public int dnum = 0;
    public int hitobj = 0;
    public string wa;
	// Use this for initialization
	void Start () {
        wa = "normal";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void WaterAmount(int amount){
        wnum += amount;
    }
    void FireAmount(int amount)
    {
        fnum += amount;
    }
    void DirtAmount(int amount)
    {
        dnum += amount;
    }
    void Hit(int amount)
    {
        hitobj += amount;
    }
    void waterstate(string a)
    {
        wa = a;
    }
    void firestate(string a)
    {
        wa = a;
    }
    void dirtstate(string a)
    {
        wa = a;
    }
}
