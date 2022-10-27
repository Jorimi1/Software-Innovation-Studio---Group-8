using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public Webcam webcam;
    public static PlayerCollect instance;
    [SerializeField] private int score;


    public GameObject bossGame;
    // Start is called before the first frame update
    private void OnEnable()
    {
        if (PlayerPrefs.HasKey("Apples"))
        {
            score = PlayerPrefs.GetInt("Apples");
        }
    }
    void Start()
    {
        webcam = GameObject.Find("Webcam").GetComponent<Webcam>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GetScore()
    {
        return score;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Collection")
        {
            // ScoreManager.instance.collectItem();                           
            Destroy(other.gameObject);
            score++;
            Debug.Log(PlayerPrefs.GetInt("Apples"));
        }

        if (other.gameObject.tag == "GoBoss")
        {
            GetComponent<PrefabWeapon>().enabled = true;
            bossGame.SetActive(true);
        }


        if (other.gameObject.tag == "NPC1")
        {
            var gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            if (webcam.emotion_status == "Happy")
            {
                other.gameObject.GetComponent<Collider2D>().enabled = false;
                gameManager.showColudOrDown(true);
            }
            else if (webcam.emotion_status == "Sad")
            {
                other.gameObject.GetComponent<Collider2D>().enabled = false;
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
                other.gameObject.GetComponent<Collider2D>().enabled = false;
                gameManager.showColudOrDown(true);
            }
            else if (webcam.emotion_status == "Sad")
            {
                other.gameObject.GetComponent<Collider2D>().enabled = false;
                gameManager.showColudOrDown(false);
            }
        }
    }

    private void OnDestroy()
        {
            saveScore();
        }

    void saveScore()
        {
            PlayerPrefs.SetInt("Apples", score);
            PlayerPrefs.Save();

        
    }

    /* if (other.gameObject.tag == "NPC1")
     {
         var gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
         if (webcam.emotion_status == "Happy")
         {
             gameManager.showColudOrDown(true);
         }
         else if (webcam.emotion_status == "Sad") {

             gameManager.showColudOrDown(false);
         }
     }*/

}

