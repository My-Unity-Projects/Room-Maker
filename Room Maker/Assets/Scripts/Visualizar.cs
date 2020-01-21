using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR;

public class Visualizar : MonoBehaviour {

	private GameObject player;
	private GameObject Cameras;

	private Button visualiza;

	private bool visactive;

	public void cambioCamara(){

		if (!visactive) {

			player.SetActive (true);
			UnityEngine.XR.XRSettings.enabled = true;

			Cameras.SetActive (false);

			visactive = true;

		} else if(visactive) {

			player.SetActive (false);
			UnityEngine.XR.XRSettings.enabled = false;

			Cameras.SetActive (true);

			visactive = false;

		}
			
	}

	// Use this for initialization
	void Start () {

		player = GameObject.Find ("OVRPlayerController");
		Cameras = GameObject.Find ("Map_Cameras");

		visactive = false;
		player.SetActive (false);
		UnityEngine.XR.XRSettings.enabled = false;

		visualiza = GameObject.Find ("Btn_Visualizar").GetComponent<Button> ();

		visualiza.onClick.AddListener (cambioCamara);

	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.V)) {

			if (!visactive) {

				player.SetActive (true);
				UnityEngine.XR.XRSettings.enabled = true;

				Cameras.SetActive (false);

				visactive = true;

			} else if(visactive) {

				player.SetActive (false);
				UnityEngine.XR.XRSettings.enabled = false;

				Cameras.SetActive (true);


				visactive = false;

			}

		}
			
	}

}
