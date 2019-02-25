using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class flagSel : MonoBehaviour {
	int itFlag = 0;
	public GameObject flag;
	public Sprite gFlag;
	public Sprite lFlag;
	public Sprite bFlag;
	public Sprite aroFlag;
	public Sprite asexFlag;
	public Sprite qFlag;
	public Sprite pFlag;
	public Sprite tFlag;
	public Sprite nbFlag;

	int itFood = 0;
	public GameObject food;
	public Sprite bread;
	public Sprite burger;
	public Sprite Fruit;
	public Sprite Roast;
	public Sprite Sushi;
	public Sprite Soup;
	public Sprite Cake;

	int itPet = 0;
	public GameObject pet;
	public Sprite Cat;
	public Sprite Dog;
	public Sprite Fish;
	public Sprite Hamster;
	public Sprite Rabbit;

	int itWall = 0;
	public GameObject wall;
	public Sprite Yellow;
	public Sprite Blue;
	public Sprite Green;
	public Sprite Grey;
	public Sprite Red;
	public Sprite Orange;
	public Sprite White;
	public Sprite Purple;

	int itPic = 0;
	public GameObject picture;
	public Sprite buildPic;
	public Sprite certPic;
	public Sprite dogPic;
	public Sprite artPic;
	public Sprite balPic;
	public Sprite carPic;
	public Sprite hopPic;
	public Sprite memePic;
	public Sprite movPic;
	public Sprite olymPic;

	int itCom = 0;
	public GameObject computer;
	public Sprite netflix;
	public Sprite music;
	public Sprite nature;
	public Sprite sport;
	public Sprite racing;
	public Sprite news;

	//public AudioSource m;
	public GameObject player;
	// Use this for initialization
	void Start () {
	//	m.Play ();
		player = GameObject.Find("player");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mousePos2D = new Vector2 (mousePosition.x, mousePosition.y);
			RaycastHit2D hit = Physics2D.Raycast (mousePos2D, Vector2.zero);
			if (hit) { 
				Debug.Log ("hit");
				if (hit.collider == this.GetComponent<Collider2D> ()) {
					Debug.Log (compareDate ());
					Debug.Log ("ding");
				} else if (hit.collider == flag.GetComponent<Collider2D> ()) {
					if (itFlag < 8) {
						itFlag += 1;
					} else {
						itFlag = 0;
					}
					Debug.Log ("flag change");
					if (itFlag == 0) {
						flag.GetComponent<SpriteRenderer> ().sprite = gFlag;
						flag.name = "Gay";
					} else if (itFlag == 1) {
						flag.GetComponent<SpriteRenderer> ().sprite = lFlag;
						flag.name = "Lesbian";
					} else if (itFlag == 2) {
						flag.GetComponent<SpriteRenderer> ().sprite = bFlag;
						flag.name = "Bisexual";
					} else if (itFlag == 3) {
						flag.GetComponent<SpriteRenderer> ().sprite = qFlag;
						flag.name = "Queer";
					} else if (itFlag == 4) {
						flag.GetComponent<SpriteRenderer> ().sprite = aroFlag;
						flag.name = "Aromantic";
					} else if (itFlag == 5) {
						flag.GetComponent<SpriteRenderer> ().sprite = asexFlag;
						flag.name = "Asexual";
					} else if (itFlag == 6) {
						flag.GetComponent<SpriteRenderer> ().sprite = nbFlag;
						flag.name = "Non-binary";
					} else if (itFlag == 7) {
						flag.GetComponent<SpriteRenderer> ().sprite = tFlag;
						flag.name = "Trans";
					} else if (itFlag == 8) {
						flag.GetComponent<SpriteRenderer> ().sprite = pFlag;
						flag.name = "Pansexual";
					}
				} else if (hit.collider == food.GetComponent<Collider2D> ()) {
					if (itFood < 6) {
						itFood += 1;
					} else {
						itFood = 0;
					}
					if (itFood == 0) {
						food.GetComponent<SpriteRenderer> ().sprite = bread;
						food.name = "Bread";
					} else if (itFood == 1) {
						food.GetComponent<SpriteRenderer> ().sprite = burger;
						food.name = "Burger";
					} else if (itFood == 2) {
						food.GetComponent<SpriteRenderer> ().sprite = Fruit;
						food.name = "Fruit";
					} else if (itFood == 3) {
						food.GetComponent<SpriteRenderer> ().sprite = Roast;
						food.name = "Roast";
					} else if (itFood == 4) {
						food.GetComponent<SpriteRenderer> ().sprite = Sushi;
						food.name = "Sushi";
					} else if (itFood == 5) {
						food.GetComponent<SpriteRenderer> ().sprite = Soup;
						food.name = "Soup";
					} else if (itFood == 6) {
						food.GetComponent<SpriteRenderer> ().sprite = Cake;
						food.name = "Cake";
					}
				} else if (hit.collider == pet.GetComponent<Collider2D> ()) {
					if (itPet < 4) {
						itPet += 1;
					} else {
						itPet = 0;
					}
					if (itPet == 0) {
						pet.GetComponent<SpriteRenderer> ().sprite = Cat;
						pet.name = "Cats";
					} else if (itPet == 1) {
						pet.GetComponent<SpriteRenderer> ().sprite = Dog;
						pet.name = "Dogs";
					} else if (itPet == 2) {
						pet.GetComponent<SpriteRenderer> ().sprite = Fish;
						pet.name = "Fish";
					} else if (itPet == 3) {
						pet.GetComponent<SpriteRenderer> ().sprite = Hamster;
						pet.name = "Hamsters";
					} else if (itPet == 4) {
						pet.GetComponent<SpriteRenderer> ().sprite = Rabbit;
						pet.name = "Rabbits";
					}
				} else if (hit.collider == wall.GetComponent<Collider2D> ()) {
					if (itWall < 7) {
						itWall += 1;
					} else {
						itWall = 0;
					}

					if (itWall == 0) {
						wall.GetComponent<SpriteRenderer> ().sprite = Yellow;
						wall.name = "Yellow";
					} else if (itWall == 1) {
						wall.GetComponent<SpriteRenderer> ().sprite = Green;
						wall.name = "Green";
					} else if (itWall == 2) {
						wall.GetComponent<SpriteRenderer> ().sprite = Blue;
						wall.name = "Blue";
					} else if (itWall == 3) {
						wall.GetComponent<SpriteRenderer> ().sprite = Purple;
						wall.name = "Purple";
					} else if (itWall == 4) {
						wall.GetComponent<SpriteRenderer> ().sprite = Grey;
						wall.name = "Grey";
					} else if (itWall == 5) {
						wall.GetComponent<SpriteRenderer> ().sprite = White;
						wall.name = "White";
					} else if (itWall == 6) {
						wall.GetComponent<SpriteRenderer> ().sprite = Red;
						wall.name = "Red";
					} else if (itWall == 7) {
						wall.GetComponent<SpriteRenderer> ().sprite = Orange;
						wall.name = "Orange";
					}
				} else if (hit.collider == picture.GetComponent<Collider2D> ()) {
					if (itPic < 9) {
						itPic += 1;
					} else {
						itPic = 0;
					}
					if (itPic == 0) {
						picture.GetComponent<SpriteRenderer> ().sprite = buildPic;
						picture.name = "Building";
					} else if (itPic == 1) {
						picture.GetComponent<SpriteRenderer> ().sprite = certPic;
						picture.name = "Certificate";
					} else if (itPic == 2) {
						picture.GetComponent<SpriteRenderer> ().sprite = dogPic;
						picture.name = "DogPic";
					} else if (itPic == 3) {
						picture.GetComponent<SpriteRenderer> ().sprite = artPic;
						picture.name = "Art";
					} else if (itPic == 4) {
						picture.GetComponent<SpriteRenderer> ().sprite = balPic;
						picture.name = "Dance";
					} else if (itPic == 5) {
						picture.GetComponent<SpriteRenderer> ().sprite = carPic;
						picture.name = "Car";
					} else if (itPic == 6) {
						picture.GetComponent<SpriteRenderer> ().sprite = hopPic;
						picture.name = "Hopscotch";
					} else if (itPic == 7) {
						picture.GetComponent<SpriteRenderer> ().sprite = memePic;
						picture.name = "Meme";
					} else if (itPic == 8) {
						picture.GetComponent<SpriteRenderer> ().sprite = movPic;
						picture.name = "Movie";
					} else if (itPic == 9) {
						picture.GetComponent<SpriteRenderer> ().sprite = olymPic;
						picture.name = "Olympic";
					}
				} else if (hit.collider == computer.GetComponent<Collider2D> ()) {
					if (itCom < 5) {
						itCom += 1;
					} else {
						itCom = 0;
					}
					if (itCom == 0) {
						computer.GetComponent<SpriteRenderer> ().sprite = netflix;
						computer.name = "Netflix";
					}
					else if (itCom == 1) {
						computer.GetComponent<SpriteRenderer> ().sprite = music;
						computer.name = "Music";
					}
					else if (itCom == 2) {
						computer.GetComponent<SpriteRenderer> ().sprite = nature;
						computer.name = "Nature";
					}
					else if (itCom == 3) {
						computer.GetComponent<SpriteRenderer> ().sprite = sport;
						computer.name = "Sport";
					}
					else if (itCom == 4) {
						computer.GetComponent<SpriteRenderer> ().sprite = racing;
						computer.name = "Racing";
					}
					else if (itCom == 5) {
						computer.GetComponent<SpriteRenderer> ().sprite = news;
						computer.name = "News";
					}
				}
			}
		}
	}

	int compareDate() {
		int per = (int)Random.Range (0, 40);
		if (player.GetComponent<Profile> ().sexuality == flag.name ||
			player.GetComponent<Profile> ().gender == flag.name ||
			(player.GetComponent<Profile> ().trans && flag.name.Equals("Trans")) ) {
			per += 20;
		}
		if (player.GetComponent<Profile> ().likes [2].Equals (food.name) || (food.name.Equals ("Sushi") &&
			player.GetComponent<Profile> ().likes [2].Equals ("Fish")) ||
			(food.name.Equals ("Soup") &&
				player.GetComponent<Profile> ().likes [2].Equals ("Noodles"))) {
			per += 10;
		}
		if (player.GetComponent<Profile> ().likes [3].Equals (pet.name) || (pet.name.Equals ("Hamsters") &&
		    (player.GetComponent<Profile> ().likes [3].Equals ("Guinea pigs") || player.GetComponent<Profile> ().likes [3].Equals ("Gerbils")))) {
			per += 10;
		}
		if (player.GetComponent<Profile> ().colour.Equals (wall.name)) {
			per += 10;
		}
		if (picture.name.Equals ("Building")) {
			if (player.GetComponent<Profile> ().occupation.Equals ("Architect") || player.GetComponent<Profile> ().occupation.Equals ("Bricklayer")) {
				per += 10;
			}
		} else if (picture.name.Equals ("Certificate")) {
			if (player.GetComponent<Profile> ().occupation.Equals ("Doctor") || player.GetComponent<Profile> ().occupation.Equals ("Dentist") || player.GetComponent<Profile> ().occupation.Equals ("Professor") || player.GetComponent<Profile> ().occupation.Equals ("Nurse") ||
			    player.GetComponent<Profile> ().occupation.Equals ("Midwife") || player.GetComponent<Profile> ().occupation.Equals ("Marriage counsellor") ||
			    player.GetComponent<Profile> ().occupation.Equals ("Therapist") || player.GetComponent<Profile> ().occupation.Equals ("Pilot")) {
				per += 10;
			}
		} else if (picture.name.Equals ("Art")) {
			if (player.GetComponent<Profile> ().occupation.Equals ("Tattoo artist") || player.GetComponent<Profile> ().occupation.Equals ("Artist")) {
				per += 10;
			}
		} else if (picture.name.Equals ("Dance")) {
			if (player.GetComponent<Profile> ().occupation.Equals ("Dancer")) {
				per += 10;
			}
		} else if (picture.name.Equals ("Car")) {
			if (player.GetComponent<Profile> ().occupation.Equals ("Racecar driver")) {
				per += 10;
			} else if (picture.name.Equals ("Hopscotch")) {
				if (player.GetComponent<Profile> ().occupation.Equals ("Hopscotch referee")) {
					per += 10;
				}
			} else if (picture.name.Equals ("Meme")) {
				if (player.GetComponent<Profile> ().occupation.Equals ("Professional meme creator")) {
					per += 10;
				}
			}
		}
		if (computer.name.Equals ("Netflix")) {
			if (player.GetComponent<Profile> ().likes [0].Equals ("Computer games") || player.GetComponent<Profile> ().likes [1].Equals ("Computer games") ||
				player.GetComponent<Profile> ().likes [0].Equals ("Memes") || player.GetComponent<Profile> ().likes [1].Equals ("Memes") ||
				player.GetComponent<Profile> ().likes [0].Equals ("Cheesy jokes") || player.GetComponent<Profile> ().likes [1].Equals ("Cheesy jokes") ||
				player.GetComponent<Profile> ().likes [0].Equals ("Neflix binges") || player.GetComponent<Profile> ().likes [1].Equals ("Neflix binges") ||
				player.GetComponent<Profile> ().likes [0].Equals ("Superheroes") || player.GetComponent<Profile> ().likes [1].Equals ("Superheroes")
			) {
				per += 10;
			}
		} else if (computer.name.Equals ("Music")) {
			if (player.GetComponent<Profile> ().likes [0].Equals ("Classical music") || player.GetComponent<Profile> ().likes [1].Equals ("Classical music") ||
			    player.GetComponent<Profile> ().likes [0].Equals ("Dance") || player.GetComponent<Profile> ().likes [1].Equals ("Dance") ||
			    player.GetComponent<Profile> ().likes [0].Equals ("Theatre") || player.GetComponent<Profile> ().likes [1].Equals ("Theatre") ||
			    player.GetComponent<Profile> ().likes [0].Equals ("Concerts") || player.GetComponent<Profile> ().likes [1].Equals ("Concerts")) {
				per += 10;
			} else if (computer.name.Equals ("Nature")) {
				if (player.GetComponent<Profile> ().likes [0].Equals ("Nature") || player.GetComponent<Profile> ().likes [1].Equals ("Nature") ||
				    player.GetComponent<Profile> ().likes [0].Equals ("Hiking") || player.GetComponent<Profile> ().likes [1].Equals ("Hiking") ||
				    player.GetComponent<Profile> ().likes [0].Equals ("Rock climbing") || player.GetComponent<Profile> ().likes [1].Equals ("Rock climbing")) {
					per += 10;
				} else if (computer.name.Equals ("Sport")) {
					if (player.GetComponent<Profile> ().likes [0].Equals ("Swimming") || player.GetComponent<Profile> ().likes [1].Equals ("Swimming") ||
					    player.GetComponent<Profile> ().likes [0].Equals ("Running") || player.GetComponent<Profile> ().likes [1].Equals ("Running") ||
					    player.GetComponent<Profile> ().likes [0].Equals ("Marathons") || player.GetComponent<Profile> ().likes [1].Equals ("Marathons")) {
						per += 10;
					}
				} else if (computer.name.Equals ("Racing")) {
					if (player.GetComponent<Profile> ().likes [0].Equals ("Driving") || player.GetComponent<Profile> ().likes [1].Equals ("Driving")) {
						per += 10;
					}
				} else if (computer.name.Equals ("News")) {
					if (player.GetComponent<Profile> ().likes [0].Equals ("Poetry") ||player.GetComponent<Profile> ().likes [1].Equals ("Poetry") ||
						player.GetComponent<Profile> ().likes [0].Equals ("Debating") || player.GetComponent<Profile> ().likes [1].Equals ("Debating")){
						per += 10;
					}
				}
			}
		}
		Debug.Log (per);
		if (per > 40) {
			SceneManager.LoadScene (5);
		} else if (per > 20) {
			SceneManager.LoadScene (4);
		} else {
			SceneManager.LoadScene (3);
		}
		return per;
	}
}
