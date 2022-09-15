using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float LeftLimit;
    public float RightLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > LeftLimit && player.transform.position.x < RightLimit){
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.8f, -10f);
        }
    }
}
