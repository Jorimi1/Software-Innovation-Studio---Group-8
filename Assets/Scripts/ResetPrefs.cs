using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPrefs : MonoBehaviour
{
    public void resetPrefValues()
    {
        //set apple collection to 0;
        PlayerPrefs.SetInt("Apples", 0);
    }
}
