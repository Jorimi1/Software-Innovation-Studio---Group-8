using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyLevelManager : MonoBehaviour
{
   public static SkyLevelManager instance;
    public Transform respawnPoint;
    public GameObject playerPrefab;
    // Start is called before the first frame update

    
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        playerPrefab = GameObject.FindGameObjectWithTag("Player");
    }
    public void Respawn()
    {
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
    }
}
