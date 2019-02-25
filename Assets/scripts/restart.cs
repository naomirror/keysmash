using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour {
	//AudioSource mm;
	// Use this for initialization
	void Start () {
	//	mm.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Destroy (GameObject.Find ("player"));
			SceneManager.LoadScene (1);
		}
	}
}
