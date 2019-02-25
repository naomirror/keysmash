using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Profile : MonoBehaviour {
	public GameObject like;
	public GameObject dislike;
	public string nme;
	public string occupation;
	public List<string> likes = new List<string>();
	public List<string> dislikes = new List<string>();
	public string sexuality;
	public string gender;
	public string colour;
	public bool trans;
	// Use this for initialization
	void Start () {
		this.gameObject.name = nme;
		this.gameObject.GetComponent<TextMesh> ().text = nme + "\n" + gender + ", " + sexuality + "\n" +
			"\n" + "Occupation: " + occupation + "\n" + "Likes: " + likes[0] + ", " + likes[1] + "\n" + "Favourite Food: " + likes[2] + "\n" +
			"Favourite Animal: " + likes[3] + "\n" + "Favourite Colour: " + colour;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePosition.x, mousePosition.y);
			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			if (hit)
			{ 
				Debug.Log ("hit");
				if (hit.collider == like.GetComponent<Collider2D> ()) {
					Debug.Log ("like");
					this.gameObject.name = "player";
					Object.DontDestroyOnLoad (this.gameObject);
					this.gameObject.transform.position = new Vector3 (1000.0f, 1000.0f, 0.0f);
					SceneManager.LoadScene ("flat");
				} else if (hit.collider == dislike.GetComponent<Collider2D> ()) {
					Debug.Log ("dislike");
					this.gameObject.SetActive (false);
					GameObject.Find ("controller").GetComponent<Persons>().createPerson();
				}
			}
		}
	}
		
}
