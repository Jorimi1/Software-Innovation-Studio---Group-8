using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level1ToDia1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Webcam web;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Dialogue1");
            web.webcamTexture.Stop();
        }
    }
}
