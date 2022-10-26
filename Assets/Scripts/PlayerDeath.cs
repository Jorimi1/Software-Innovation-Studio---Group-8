using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject fallDetector;
    private Vector3 respawnPoint;

    void Start()
    {
        /*Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "SkyLevel")
        {
            fallDetector = GameObject.FindGameObjectWithTag("FallDetector");
            respawnPoint = GameObject.Find("RespawnPoint").transform.position;
        }*/
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "SkyLevel")
        {
            fallDetector = GameObject.FindGameObjectWithTag("FallDetector");
            respawnPoint = GameObject.Find("RespawnPoint").transform.position;
            if (other.gameObject.tag == "FallDetector")
            {
                transform.position = respawnPoint;
            }
        }

        /*if (other.gameObject.tag == "FallDetector")
            {
                transform.position = respawnPoint;
            }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

