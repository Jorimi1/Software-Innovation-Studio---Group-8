using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private float bounce = 20f;
    // Start is called before the first frame update
    private void onCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("[Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
}