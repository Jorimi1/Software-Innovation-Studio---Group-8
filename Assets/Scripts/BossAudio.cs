using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BossAudio : MonoBehaviour
{
    public GameObject gameObject;
    private AudioSource audioSource1;
    public GameObject gameObject2;
    private AudioSource audioSource2;
    public GameObject gameObject3;
    private AudioSource audioSource3;
    public static int BossDead = 0;
    private int paused = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource1 = gameObject.GetComponent<AudioSource>();
        audioSource2 = gameObject2.GetComponent<AudioSource>();
        audioSource3 = gameObject3.GetComponent<AudioSource>();
        audioSource1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(BossDead == 1 && paused == 0){
            audioSource1.Pause();
            audioSource2.Play();
            paused = 1;
        }
        if(Input.GetMouseButtonDown(0)){
            audioSource3.Play();
        }
    }
}
