using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Collections.Generic;


public class LeaderBoard : MonoBehaviour
{
    public Text scoreLabel1;
    public Text scoreLabel2;
    public Text scoreLabel3;
    public Text scoreLabel4;
    public Text scoreLabel5;
    public Text scoreLabel6;
    public Text scoreLabel7;
    public Text scoreLabel8;
    int[] score0 ={0,0,0,0,0,0,0,0,0};
    int s;
    int temp;
    string str1;
    string str2;
    int cur;
    int j;
    void Start()
    {
        j = startview.j;
        score();
    }

    // Update is called once per frame
    void Update()
    {
        str1 = "{0}";
        str2 = "<color=yellow>{0}</color>";
        cur = PlayerPrefs.GetInt("Current Game",-1);
        print(cur);
        scoreLabel1.text = string.Format(cur== 0?str2:str1 , score0[0]);
        scoreLabel2.text = string.Format(cur == 1 ? str2 : str1, score0[1]);
        scoreLabel3.text = string.Format(cur == 2 ? str2 : str1, score0[2]);
        scoreLabel4.text = string.Format(cur == 3 ? str2 : str1, score0[3]);
        scoreLabel5.text = string.Format(cur == 4 ? str2 : str1, score0[4]);
        scoreLabel6.text = string.Format(cur == 5 ? str2 : str1, score0[5]);
        scoreLabel7.text = string.Format(cur == 6 ? str2 : str1, score0[6]);
        scoreLabel8.text = string.Format(cur ==7 ? str2 : str1, score0[7]);
    }
    void score()
    {
        s = Sec.send;
        score0[8] = s;
        score0[0] = PlayerPrefs.GetInt("score1", 0);
        score0[1] = PlayerPrefs.GetInt("score2", 0);
        score0[2] = PlayerPrefs.GetInt("score3", 0);
        score0[3] = PlayerPrefs.GetInt("score4", 0);
        score0[4] = PlayerPrefs.GetInt("score5", 0);
        score0[5] = PlayerPrefs.GetInt("score6", 0);
        score0[6] = PlayerPrefs.GetInt("score7", 0);
        score0[7] = PlayerPrefs.GetInt("score8", 0);
        PlayerPrefs.DeleteKey("Current Game");
        if (j == 1)
        {
            for (int i = 7; i >= 0; i--)
            {
                if (score0[i + 1] > score0[i])
                {
                    temp = score0[i + 1];
                    score0[i + 1] = score0[i];
                    score0[i] = temp;
                    PlayerPrefs.SetInt("Current Game", i);
                    continue;
                }

                break;
            }
        }
            PlayerPrefs.SetInt("score1", score0[0]);
            PlayerPrefs.SetInt("score2", score0[1]);
            PlayerPrefs.SetInt("score3", score0[2]);
            PlayerPrefs.SetInt("score4", score0[3]);
            PlayerPrefs.SetInt("score5", score0[4]);
            PlayerPrefs.SetInt("score6", score0[5]);
            PlayerPrefs.SetInt("score7", score0[6]);
            PlayerPrefs.SetInt("score8", score0[7]);
       
    }
}
