using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossToWin : MonoBehaviour
{
    private static string emotion;
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
            if(emotion == "Happy"){
                SceneManager.LoadScene("Dialogue2");
            }else if(emotion == "Angey"){
                SceneManager.LoadScene("Dialogue3");
            }else{

            }

   
            
        }
    }

    public static void PassValue(string s){
        emotion =  s;
    }
}
