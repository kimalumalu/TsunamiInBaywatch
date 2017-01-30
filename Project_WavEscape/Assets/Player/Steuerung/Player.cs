using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private float movespeed = 0.1f;
	private Rigidbody rb;
	private Animator anim;

	public GameObject DeathUI;
	public GameObject WinUI;


	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
		Time.timeScale = 1f;
	}

	void Update () {
		if (Input.GetKey ("a")) {
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+movespeed);
		    transform.Rotate (0,-1f,0);
		}

		if (Input.GetKey ("d")) {
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+movespeed*-1);
			transform.Rotate (0,1f,0);
		}

		if (Input.GetKey ("s")) {
			transform.position = new Vector3(transform.position.x+movespeed*-1, transform.position.y, transform.position.z);
		}

		if (Input.GetKey("w")){
			transform.position = new Vector3(transform.position.x+movespeed*1, transform.position.y, transform.position.z);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 8) {

			DeathUI.gameObject.SetActive (true);
			Time.timeScale = 0f;
			//SceneManager.LoadScene(0);

		}

		if (other.gameObject.layer == 9) {
			WinUI.gameObject.SetActive (true);
			Time.timeScale = 0f;
			//SceneManager.LoadScene(0);

		}
	}
}