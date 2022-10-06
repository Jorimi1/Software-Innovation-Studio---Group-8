using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLevelControl : MonoBehaviour
{
    public GameObject player;

    public GameObject boss;

    private int instboss = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x >= 0f && instboss == 1){
            Instantiate(boss, new Vector3(10, -1.5f, -1), Quaternion.identity);
            instboss = 0;
        }
        
    }
}
