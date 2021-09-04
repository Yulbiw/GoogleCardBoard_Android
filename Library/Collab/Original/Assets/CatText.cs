﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatText : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject cat;
    public int scoreToWin = 3;
    public Text myText;
    void Start()
    {
        UiObject.setActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {


            if (FishScore.scoreValue >= scoreToWin)
            {
                UiObject.setActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        UiObject.setActive(false);
        Destroy(cat);
    }

}
