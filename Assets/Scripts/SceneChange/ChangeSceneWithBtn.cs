using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithBtn : MonoBehaviour
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
    public void Changescene(string name) {  
        SceneManager.LoadScene("Start Menu");
        web.webcamTexture.Stop();
        Debug.Log("Works");
    }  
}
