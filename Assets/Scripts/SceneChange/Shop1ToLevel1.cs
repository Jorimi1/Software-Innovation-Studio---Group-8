using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop1ToLevel1 : MonoBehaviour
{
    public GameObject gameObject;
    public Webcam web;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag == "Player")
        {
            //text.enabled=true;
            if(Input.GetKeyDown(KeyCode.H)){
                SceneManager.LoadScene("Level1");
                web.webcamTexture.Stop();
                //Instantiate(gameObject, new Vector3(30, 0, 0), Quaternion.identity);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
         //text.enabled=false;
    }
}
