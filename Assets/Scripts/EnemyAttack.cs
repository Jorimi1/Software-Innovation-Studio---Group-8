using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var theBarRectTransform = gameObject.transform as RectTransform;
        if(theBarRectTransform.sizeDelta.x == 0){
            SceneManager.LoadScene("DeadScene");
        }
    }

    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag == "Player")
        { 
            var theBarRectTransform = gameObject.transform as RectTransform;
            theBarRectTransform.sizeDelta = new Vector2 (theBarRectTransform.sizeDelta.x-2, theBarRectTransform.sizeDelta.y);
            theBarRectTransform.anchoredPosition = new Vector2(theBarRectTransform.anchoredPosition.x - 1, theBarRectTransform.anchoredPosition.y);
        }
        
    }

    void OnTriggerExit2D(Collider2D other){
         
    }
}
