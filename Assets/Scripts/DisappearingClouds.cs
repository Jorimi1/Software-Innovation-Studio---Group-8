using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingClouds : MonoBehaviour
{
    private float fallDelay = 1f;
    private float destroyDelay = 2f;

    private Rigidbody2D rb;
    //public Collider2D cloud;
    //public Collider2D player;

    // Start is called before the first frame update
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        //cloud = GameObject.FindGameObjectWithTag("DisappearingCloud").GetComponent<Collider2D>();
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        Physics2D.IgnoreLayerCollision(3, 3);
    }

    /*private void Collide()
    {
        if (cloud.IsTouching(player))
        {
            Debug.Log("touching");
        }
    }*/
    
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(Fall());
            Debug.Log("Player collision");
        }

    }
    
    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }

}
