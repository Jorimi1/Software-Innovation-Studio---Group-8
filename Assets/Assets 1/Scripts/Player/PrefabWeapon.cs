using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabWeapon : MonoBehaviour {

	public Transform firePoint;
	public GameObject bulletPrefab;

	public Webcam webcam;
	public bool isRes = false;
	// Update is called once per frame
	void Update () {


		// if (webcam.emotion_status == "Happy")
		// {
		// 	Shoot();
		// }


		if (Input.GetMouseButtonDown(0))
       {
           Shoot();
       }


    }

	void Shoot ()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}
