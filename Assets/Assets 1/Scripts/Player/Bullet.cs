using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public Webcam webcam;
	public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		BossHealth enemy = hitInfo.GetComponent<BossHealth>();
		string emotion = webcam.emotion_status;

		if (enemy != null) 
		{
			if (emotion == "Happy")
			{
				enemy.TakeDamage(damage*2);
			}
			else if (emotion == "Sad")
			{
				enemy.TakeDamage(damage/2);
			}
		}

		Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}
	
}
