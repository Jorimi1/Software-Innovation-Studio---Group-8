using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossToWin : MonoBehaviour
{
    public Webcam webcam;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player")
        {
            string emotion = webcam.emotion_status;

            switch (emotion) {
                case "Happy":
                    SceneManager.LoadScene("HappyWinDialogue");
                    break;
                case "Angry":
                    SceneManager.LoadScene("AngryWinDialogue");
                    break;
                case "Sad":
                    SceneManager.LoadScene("SadWinDialogue");
                    break;
                default:
                    SceneManager.LoadScene("Dialogue2");
                    break;
            }

        }
    }

    public static void PassValue(string s){
        emotion =  s;
    }
}
