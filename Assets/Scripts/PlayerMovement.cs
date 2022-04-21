using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour 
{
	private Rigidbody rb;
	public float speed;
	public GameObject deathParticles;
	private Vector3 spawn;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		spawn = transform.position;
	}



	void FixedUpdate()
	{
		float x = Input.GetAxis ("Horizontal");
		float y = 0.0f;
		float z = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (x, y, z);
		rb.AddForce (movement * speed);
		if (Input.GetButton ("Fire1")) 
		{
			Instantiate (deathParticles, transform.position, Quaternion.identity);
			transform.position = spawn;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Enemy")) 
		{
				Instantiate (deathParticles, transform.position, Quaternion.identity);
				transform.position = spawn;
		}
	}
}