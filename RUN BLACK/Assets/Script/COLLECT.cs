using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Collections.Generic;

public class COLLECT : MonoBehaviour {
    private GameObject[] arrayA = new GameObject[14];
    int[] arrayN = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};//開一個陣列先設為0
    
    /*讀取你的水火土值*/


    // Use this for initialization
    void Start () {
        /*int f_n = Change.f_n;
        int w_n = Change.w_n;
        int D_n = Change.d_n;*/
        arrayA[0]= GameObject.Find("A0");
        arrayA[1] = GameObject.Find("A1");
        arrayA[2] = GameObject.Find("A2");
        arrayA[3] = GameObject.Find("A3");
        arrayA[4] = GameObject.Find("A4");
        arrayA[5] = GameObject.Find("A5");
        arrayA[6] = GameObject.Find("A6");
        arrayA[7] = GameObject.Find("A7");
        arrayA[8] = GameObject.Find("A8");
        arrayA[9] = GameObject.Find("A9");
        arrayA[10] = GameObject.Find("A10");
        arrayA[11] = GameObject.Find("A11");
        arrayA[12] = GameObject.Find("A12");
        arrayA[13] = GameObject.Find("A13");


        for (var i = 1; i < 14; i++)
        {
            
             arrayA[i].SetActive(false); //把他們都關掉

        }
        /*先找到所有物件*/
        arrayN[1] = PlayerPrefs.GetInt("arrayX[1]");
        arrayN[2] = PlayerPrefs.GetInt("arrayX[2]");
        arrayN[3] = PlayerPrefs.GetInt("arrayX[3]");
        arrayN[4] = PlayerPrefs.GetInt("arrayX[4]");
        arrayN[5] = PlayerPrefs.GetInt("arrayX[5]");
        arrayN[6] = PlayerPrefs.GetInt("arrayX[6]");
        arrayN[7] = PlayerPrefs.GetInt("arrayX[7]");
        arrayN[8] = PlayerPrefs.GetInt("arrayX[8]");
        arrayN[9] = PlayerPrefs.GetInt("arrayX[9]");
        arrayN[10] = PlayerPrefs.GetInt("arrayX[10]");
        arrayN[11] = PlayerPrefs.GetInt("arrayX[11]");
        arrayN[12] = PlayerPrefs.GetInt("arrayX[12]");
        arrayN[13] = PlayerPrefs.GetInt("arrayX[13]");
        for (var i = 1; i < 14; i++)
        {
            if (arrayN[i] == 1)
            { arrayA[i].SetActive(true); }//讀取如果==1的話就把他打開

        }

       



    }
	
	// Update is called once per frame
	void Update () {
        

        arrayN[1] = Change.array[1];
        arrayN[2] = Change.array[2];
        arrayN[3] = Change.array[3];
        arrayN[4] = Change.array[4];
        arrayN[5] = Change.array[5];
        arrayN[6] = Change.array[6];
        arrayN[7] = Change.array[7];
        arrayN[8] = Change.array[8];
        arrayN[9] = Change.array[9];
        arrayN[10] = Change.array[10];
        arrayN[11] = Change.array[11];
        arrayN[12] = Change.array[12];
        arrayN[13] = Change.array[13];
      


        for (var i = 1; i < 14; i++)
        { 
            if (arrayN[i] == 1)
            { arrayA[i].SetActive(true); }//如果==1的話就把他打開

        }
        if (PlayerPrefs.GetInt("arrayX[1]") == 0)
            PlayerPrefs.SetInt("arrayX[1]", arrayN[1]);
        if (PlayerPrefs.GetInt("arrayX[2]") == 0)
            PlayerPrefs.SetInt("arrayX[2]", arrayN[2]);
        if (PlayerPrefs.GetInt("arrayX[3]") == 0)
            PlayerPrefs.SetInt("arrayX[3]", arrayN[3]);
        if (PlayerPrefs.GetInt("arrayX[4]") == 0)
            PlayerPrefs.SetInt("arrayX[4]", arrayN[4]);
        if (PlayerPrefs.GetInt("arrayX[5]") == 0)
            PlayerPrefs.SetInt("arrayX[5]", arrayN[5]);
        if (PlayerPrefs.GetInt("arrayX[6]") == 0)
            PlayerPrefs.SetInt("arrayX[6]", arrayN[6]);
        if (PlayerPrefs.GetInt("arrayX[7]") == 0)
            PlayerPrefs.SetInt("arrayX[7]", arrayN[7]);
        if (PlayerPrefs.GetInt("arrayX[8]") == 0)
            PlayerPrefs.SetInt("arrayX[8]", arrayN[8]);
        if (PlayerPrefs.GetInt("arrayX[9]") == 0)
            PlayerPrefs.SetInt("arrayX[9]", arrayN[9]);
        if (PlayerPrefs.GetInt("arrayX[10]") == 0)
            PlayerPrefs.SetInt("arrayX[10]", arrayN[10]);
        if (PlayerPrefs.GetInt("arrayX[11]") == 0)
            PlayerPrefs.SetInt("arrayX[11]", arrayN[11]);
        if (PlayerPrefs.GetInt("arrayX[12]") == 0)
            PlayerPrefs.SetInt("arrayX[12]", arrayN[12]);
        if (PlayerPrefs.GetInt("arrayX[13]") == 0)
            PlayerPrefs.SetInt("arrayX[13]", arrayN[13]);
        /*如果本來是零 在存黨*/


        /*if ((w_n + f_n + D_n) > 10)
        {
            switch (w_n / (f_n + D_n))
            {
                case 1:
                    arrayA[1].SetActive(true);
                   array[1] = 1;//如果這個角色出現過就把值設為1
                   PlayerPrefs.SetInt ("array[1]B", array[1]);//然後把它存起來
                    break;
                case 2:
                    arrayA[2].SetActive(true);
                   array[2] = 1;PlayerPrefs.SetInt ("array[2]B", array[2]);
                    break;
                case 3:
                    arrayA[3].SetActive(true);
                    array[3] = 1;PlayerPrefs.SetInt ("array[3]B", array[3]);
                    break;
                case 4:
                    arrayA[10].SetActive(true);
                    array[10] = 1; PlayerPrefs.SetInt("array[10]B", array[10]);
                    break;
                default:
                    break;
            }
            switch (f_n / (w_n + D_n))
            {
                case 1:
                    arrayA[4].SetActive(true);array[4] = 1;PlayerPrefs.SetInt ("array[4]B", array[4]);
                    break;
                case 2:
                    arrayA[5].SetActive(true);array[5] = 1;PlayerPrefs.SetInt ("array[5]B", array[5]);
                    break;
                case 3:
                    arrayA[6].SetActive(true);array[6] = 1;PlayerPrefs.SetInt ("array[6]B", array[6]);
                    break;
                case 4:
                    arrayA[12].SetActive(true);
                    array[12] = 1; PlayerPrefs.SetInt("array[12]", array[12]);
                    break;
                default:
                    break;
            }
            switch (D_n / (w_n + f_n))
            {
                case 1:
                    arrayA[7].SetActive(true);array[7] = 1;PlayerPrefs.SetInt ("array[7]B", array[7]);
                    break;
                case 2:
                    arrayA[8].SetActive(true);array[8] = 1;PlayerPrefs.SetInt ("array[8]B", array[8]);
                    break;
                case 3:
                    arrayA[9].SetActive(true);array[9] = 1;PlayerPrefs.SetInt ("array[9]B", array[9]);
                    break;
                case 4:
                    arrayA[11].SetActive(true);
                    array[11] = 1; PlayerPrefs.SetInt("array[11]B", array[11]);
                    break;
                case 5:
                    arrayA[13].SetActive(true);
                    array[13] = 1; PlayerPrefs.SetInt("array[13]B", array[13]);
                    break;
                default:
                    break;
            }
            
    
}*/



    }
}
