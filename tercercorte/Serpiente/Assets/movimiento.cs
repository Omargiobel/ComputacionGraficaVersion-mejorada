using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D)){

			transform.Translate(new Vector3(20f,0f,0f)*Time.deltaTime);

		}

		if (Input.GetKey(KeyCode.A)){

			transform.Translate(new Vector3(-20f,0f,0f)*Time.deltaTime);

		}
	
	if (Input.GetKey(KeyCode.W)){

		transform.Translate(new Vector3(0f,0f,-20f)*Time.deltaTime);

	}

	if (Input.GetKey(KeyCode.S)){

		transform.Translate(new Vector3(0f,0f,20f)*Time.deltaTime);

	}
}
}