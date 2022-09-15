using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{ 
    public static ScoreManager instance;
    public Image image1;
    public Image image2;
    public Image image3;
    public static float Score { set;get; }
    double collectedNumber = 0;
    
    void Start()
    {
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;
        if(instance == null){
            instance= this;
        }
    }

    // Update is called once per frame
    public void collectItem(){
        collectedNumber++;
        
        if(collectedNumber == 1){
            image1.enabled = true;
        }
        else if(collectedNumber == 2){
            image2.enabled = true;
        }
        else if(collectedNumber == 3){
            image3.enabled = true;
        }
    }
}