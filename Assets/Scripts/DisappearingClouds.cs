using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingClouds : MonoBehaviour
{
    private float fallDelay = 1f;
    private float destroyDelay = 2f;

    private Rigidbody2D rb;  

    // Start is called before the first frame update
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void onCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
            Debug.Log("Player collision");
        }

    }
    
    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.isKinematic = false;
        Destroy(gameObject, destroyDelay);
    }

}
