using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Camera : MonoBehaviour {

	public float horizontalSpeed;
	public float verticalSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {

			transform.Translate (0, 0, 3.0f);

		} else 
			if (Input.GetKey (KeyCode.S)) {

				transform.Translate (0, 0, -3.0f);

			} else 
				if (Input.GetKey (KeyCode.A)) {

					transform.Translate (-3.0f, 0, 0);
								
				} else 
					if (Input.GetKey (KeyCode.D)) {

						transform.Translate (3.0f, 0, 0);

					
					}
			

	}
}
