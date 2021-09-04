using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatText : MonoBehaviour
{
    //public FishScore FishScore;
    public GameObject WinText;
    public int scoreToWin = 3;
    //public Text myText = null;


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (FishScore.scoreValue >= scoreToWin)
            {
                //myText.text = "Win!";
                WinText.SetActive(true);
            }
        }      
    }
}
