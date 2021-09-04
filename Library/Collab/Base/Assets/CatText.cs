using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatText : MonoBehaviour
{
    public int scoreToWin = 3;
    public Text myText;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "finish")
        {
            if (FishScore.scoreValue >= scoreToWin)
            {
                myText.text = "Win!";
            }
        }      
    }
}
