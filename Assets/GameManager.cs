using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] games;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showColudOrDown(bool isShow) {

        if (isShow)
        {

            games[0].SetActive(true);
        }
        else {

            games[1].SetActive(true);
        }
    }
}
