﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

    private int click;
    void Start()
    {
        click = 0;
    }
    public void gameStart()
    {
        SceneManager.LoadScene("main");
    }
    public void credit()
    {

    }
    public void logoCredit()
    {
        click++;
        if (click == 1000)
        {
            //SceneManager.LoadScene)("");
        }
    }
}