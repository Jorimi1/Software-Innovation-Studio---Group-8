using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHead : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<EnemyStomp>())
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, 0f);
            playerRb.AddForce(Vector2.up * 300f);

        }

    }
}
