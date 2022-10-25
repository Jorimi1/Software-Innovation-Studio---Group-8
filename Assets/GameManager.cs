using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] games;

    public GameObject[] tipsGames;
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
            tipsGames[0].SetActive(true);
            games[0].SetActive(true);
        }
        else {
            tipsGames[1].SetActive(true);
            games[1].SetActive(true);
        }
    }
}
