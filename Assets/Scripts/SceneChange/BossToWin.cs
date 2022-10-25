using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossToWin : MonoBehaviour
{
    //public Webcam webcam;
    private static string emotion;
    public Webcam web;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player")
        {
            //string emotion = webcam.emotion_status;

            switch (emotion) {
                case "Happy":
                    SceneManager.LoadScene("HappyWinDialogue");
                    web.webcamTexture.Stop();
                    break;
                case "Angry":
                    SceneManager.LoadScene("AngryWinDialogue");
                    web.webcamTexture.Stop();
                    break;
                case "Sad":
                    SceneManager.LoadScene("SadWinDialogue");
                    web.webcamTexture.Stop();
                    break;
                default:
                    SceneManager.LoadScene("Dialogue2");
                    web.webcamTexture.Stop();
                    break;
            }

        }
    }

    public static void PassValue(string s){
        emotion =  s;
    }
}
