using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : MonoBehaviour
{
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
	Renderer renderer = GetComponent<Renderer>();
	renderer.material.mainTexture = webcamTexture;
	renderer.material.shader = Shader.Find("Unlit/Texture");
	webcamTexture.Play();
    }
}
