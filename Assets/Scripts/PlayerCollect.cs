using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public Webcam webcam;



    // Start is called before the first frame update
    void Start()
    {
        webcam = GameObject.Find("Webcam").GetComponent<Webcam>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Collection")
        {
            ScoreManager.instance.collectItem();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "NPC1")
        {
            var gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            if (webcam.emotion_status == "Happy")
            {
                other.gameObject.tag = "";
                gameManager.showColudOrDown(true);
            }
            else if (webcam.emotion_status == "Sad")
            {
                other.gameObject.tag = "";
                gameManager.showColudOrDown(false);
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "NPC1")
        {
            var gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            if (webcam.emotion_status == "Happy")
            {
                other.gameObject.tag = "";
                gameManager.showColudOrDown(true);
            }
            else if (webcam.emotion_status == "Sad")
            {
                other.gameObject.tag = "";
                gameManager.showColudOrDown(false);
            }
        }
    }
}
