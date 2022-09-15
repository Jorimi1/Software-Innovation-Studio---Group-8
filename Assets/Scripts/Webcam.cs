using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : MonoBehaviour
{
    private WebCamTexture webcamTexture;
    void Start()
    {
        webcamTexture = new WebCamTexture();
	    Renderer renderer = GetComponent<Renderer>();
	    renderer.material.mainTexture = webcamTexture;
	    renderer.material.shader = Shader.Find("Unlit/Texture");
	    webcamTexture.Play();
    }

    void Update(){
         if (webcamTexture.isPlaying && Input.GetKeyDown(KeyCode.P)){
            webcamTexture.Stop();
         }else if(!webcamTexture.isPlaying && Input.GetKeyDown(KeyCode.P)){
            webcamTexture.Play();
         }
    }
}
