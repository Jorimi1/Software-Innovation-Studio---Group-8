using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1ToShop1 : MonoBehaviour
{
    public Camera cam;
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
                SceneManager.LoadScene("Level1Shop1");
                DontDestroyOnLoad(other);
                //DontDestroyOnLoad(cam);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other){
         //text.enabled=false;
    }
}
