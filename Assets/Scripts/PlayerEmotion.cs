using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEmotion : MonoBehaviour
{
    public string emotion = "neutral";

    void start() {
	print(getEmotion());
    }

    public string getEmotion() {
        return emotion;
    }

    public void changeEmotion(string newEmotion) {
        emotion = newEmotion;
    }
}
