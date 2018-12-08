using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BulletLoop : MonoBehaviour
{

	public GameObject Bullet;
	public float FireRate;
	public float NextFire;

	void Start ()
	{
		FireRate = 1f;
		NextFire = Time.time;

	}
	
	void Update ()
	{

		BunnyBulletLoop();
	}
	
	void BunnyBulletLoop()
	{
		if (Time.time > NextFire)
		{
			Instantiate(Bullet, transform.position, Quaternion.identity);
			NextFire = Time.time + FireRate;
		}
	}
}
