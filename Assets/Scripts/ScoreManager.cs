using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;

    void Start()
    {
        score = PlayerPrefs.GetInt("CollectedApples");

        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore (int value)
    {
        score += value;
        text.text = "x" + score.ToString();
        PlayerPrefs.SetInt("CollectedApples", score);
    }
    /*public Image image1;
    public Image image2;
    public Image image3;
    public static float Score { set; get; }
    public static int collectedNumber = 0;
    
    void Awake(){}

    void Start()
    {
        //disable all images
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;

        //get apple value in levelboss
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName != "Level1")
        {
            collectedNumber = PlayerPrefs.GetInt("collectedapple");
            if (collectedNumber == 1)
            {
                image1.enabled = true;
            }
            else if (collectedNumber == 2)
            {
                image2.enabled = true;
            }
            else if (collectedNumber == 3)
            {
                image3.enabled = true;
            }
            
        }
        
        PlayerPrefs.SetInt("collectedapple", 0);
        //instance
        if (instance == null)
            {
                instance = this;
            }

        


    }

    // Update is called once per frame
    public void collectItem()
    {
        collectedNumber++;

        if (collectedNumber == 1)
        {
            image1.enabled = true;
        }
        else if (collectedNumber == 2)
        {
            image1.enabled = true;
            image2.enabled = true;
        }
        else if (collectedNumber == 3)
        {
            image1.enabled = true;
            image2.enabled = true;
            image3.enabled = true;
        }

        //set apple value in level1
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Level1")
        {
            PlayerPrefs.SetInt("collectedapple", collectedNumber);
            Debug.Log(PlayerPrefs.GetInt("collectedapple"));
        }
    }*/
}