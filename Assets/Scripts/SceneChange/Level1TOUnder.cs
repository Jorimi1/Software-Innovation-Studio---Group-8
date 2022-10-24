using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Level1TOUnder : MonoBehaviour
{
    public TextMeshPro text;
    private Webcam web;
    // Start is called before the first frame update
    void Start()
    {
        text.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag == "Player")
        {
            text.enabled=true;
            if(Input.GetKeyDown(KeyCode.H)){
                SceneManager.LoadScene("UnderLevel");
                web.webcamTexture.Stop();
                DontDestroyOnLoad(other);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
         text.enabled=false;
    }
}
