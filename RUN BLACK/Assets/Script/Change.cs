using UnityEngine;
using System.Collections;

public class Change : MonoBehaviour {
    public static int w_n;
    public static int f_n;
    public static int d_n;
    public int a;
    public int b;
    public int c;
    public static int[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    // Use this for initialization
    void Start () {

        a = 0;
        b = 0;
        c = 0;
	}
	
	// Update is called once per frame
    void Update()
    {
        w_n = GameObject.FindWithTag("Player").GetComponent<PlayerState>().wnum;
        f_n = GameObject.FindWithTag("Player").GetComponent<PlayerState>().fnum;
        d_n = GameObject.FindWithTag("Player").GetComponent<PlayerState>().dnum;
        changean();
    }
    void changean()
    {

        if ((w_n + f_n + d_n) > 10 && f_n * d_n * w_n != 0)
        {
            switch (w_n / (f_n + d_n))
            {
                case 1:
                    GetComponent<Animator>().Play("WaterE_1");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "water");
                    array[1] = 1;
                    if (a == 0 || a == 3)
                    {
                        a += 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 1);
                        GameObject.Find("score").SendMessage("scorecount", 3);
                        
                    }
                    else if (a == 1 || a == 4)
                    {
                        a = 1;
                    }
                    break;
                case 2:
                    GetComponent<Animator>().Play("WaterE_2");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "water");
                    array[2] = 1;
                    if (a == 0 || a == 1)
                    {
                        a += 2;
                        GameObject.FindWithTag("Player").SendMessage("sound", 1);
                        GameObject.Find("score").SendMessage("scorecount", 3);
                        
                    }
                    else if (a == 3 || a == 2)
                    {
                        a = 3;
                    }
                    break;
                case 3:
                    GetComponent<Animator>().Play("WaterE_3");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "water");
                    array[3] = 1;
                    if (a == 3 || a == 0)
                    {
                        a -= 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 1);
                        GameObject.Find("score").SendMessage("scorecount", 3);

                        
                    }
                    else if (a == 2 || a < 0)
                    {
                        a = 1;
                    }
                    break;
                case 4:
                    GetComponent<Animator>().Play("E_2");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "water");
                    array[4] = 1;
                    if (a == 1 || a == 0)
                    {
                        a += 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 1);
                        GameObject.Find("score").SendMessage("scorecount", 3);

                        
                    }
                    else if (a == 2)
                    {
                        a = 2;
                    }
                    break;
            }
            switch (f_n / (w_n + d_n))
            {
                case 1:
                    GetComponent<Animator>().Play("FireE_1");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "fire");
                    array[5] = 1;
                    if (b == 0 || b == 3)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("firefast", 1);
                        }
                        b += 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 1);
                        GameObject.Find("score").SendMessage("scorecount", 3);
                        
                            
                    }
                    else if (b == 1 || b == 4)
                    {
                        b = 1;
                    }
                    break;
                case 2:
                    GetComponent<Animator>().Play("FireE_2");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "fire");
                    array[6] = 1;
                    if (b == 0 || b == 1)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("firefast", 1);
                        }
                        b += 2;
                        GameObject.FindWithTag("Player").SendMessage("sound", 1);
                        GameObject.Find("score").SendMessage("scorecount", 3);
                    }
                    else if (b == 3 || b == 2)
                    {
                        b = 3;
                    }
                    break;
                case 3:
                    GetComponent<Animator>().Play("FireE_3");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "fire");
                    array[7] = 1;
                    if (b == 3 || b == 0)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("firefast", 1);
                        }
                        b -= 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 1);
                        GameObject.Find("score").SendMessage("scorecount", 3);

                    }
                    else if (b == 2 || b < 0)
                    {
                        b = 1;
                    }
                    break;
                case 4:
                    GetComponent<Animator>().Play("E_4");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "fire");
                    array[8] = 1;
                    if (b == 1 || b == 0)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("firefast", 1);
                        }
                        b += 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 1);
                        GameObject.Find("score").SendMessage("scorecount", 3);
                    }
                    else if (b == 2)
                    {
                        b = 2;
                    }
                    break;
            }
            
            switch (d_n / (w_n + f_n))
            {
                case 1:
                    GetComponent<Animator>().Play("DirtE_1");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "dirt");
                    array[9] = 1;
                    if (c == 0 || c == 3)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("dirtslow", 1);
                        }
                        c += 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 3);
                        GameObject.Find("score").SendMessage("scorecount", 3);

                    }
                    else if (c == 1 || c == 4)
                    {
                        c = 1;
                    }
                    break;
                case 2:
                    GetComponent<Animator>().Play("DirtE_2");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "dirt");
                    array[10] = 1;
                    if (c == 0 || c == 1)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("dirtslow", 1);
                        }
                        c += 2;
                        GameObject.FindWithTag("Player").SendMessage("sound", 3);
                        GameObject.Find("score").SendMessage("scorecount", 3);

                    }
                    else if (c == 3 || c == 2)
                    {
                        c = 3;
                    }
                    break;
                case 3:
                    GetComponent<Animator>().Play("DirtE_3");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "dirt");
                    array[11] = 1;
                    if (c == 3 || c == 0)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("dirtslow", 1);
                        }
                        c -= 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 3);
                        GameObject.Find("score").SendMessage("scorecount", 3);


                    }
                    else if (c == 2 || c < 0)
                    {
                        c = 1;
                    }
                    break;
                case 4:
                    GetComponent<Animator>().Play("E_3");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "dirt");
                    array[12] = 1;
                    if (c == 1 || c == 0)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("dirtslow", 1);
                        }
                        c += 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 3);
                        GameObject.Find("score").SendMessage("scorecount", 3);


                    }
                    else if (c == 2)
                    {
                        c = 3;
                    }
                    break;
                case 5:
                    GetComponent<Animator>().Play("E_1");
                    GameObject.FindWithTag("Player").SendMessage("waterstate", "dirt");
                    array[13] = 1;
                    if (c == 0 || c == 3)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            GameObject.FindGameObjectsWithTag("BG")[i].SendMessage("dirtslow", 1);
                        }
                        c += 1;
                        GameObject.FindWithTag("Player").SendMessage("sound", 3);
                        GameObject.Find("score").SendMessage("scorecount", 3);
                    }
                    else if (c == 1 || c == 4)
                    {
                        c = 1;
                    }
                    break;
            }
        }
    }
}
