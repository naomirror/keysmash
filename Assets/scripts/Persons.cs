using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Persons : MonoBehaviour{
	//public AudioSource cm;
	public GameObject profile;
	string[] mNames = { "Harry", "Peter", "Henry", "Arthur", "Richard", "James", "Alex", "Joe", "Eric",
		"Jack", "Reggie", "Fred", "Sam", "David", "Liam", "Kevin", "Stephen", "Max", "Louis", "Frank",
	"Oscar", "Paul", "Andrew", "Matt", "Anthony", "Chris", "Charlie", "Kyle", "Ryan", "Chad", "Aaron", 
	"Jason", "Isaac", "Evan", "Zach", "Tom", "Gary", "Lawrence", "Austin"};

	string[] occupations = { "Teacher", "Actor", "Dentist", "Doctor", "Game designer", "Author", "Poet",
	"Musician", "Architect", "Professional guinea pig impersonator", "Freelance dog yoga instructor",
	"Dog trainer", "Unemployed", "Artist", "Professional meme creator", "Competitive neck hula-hooper",
	"Tattoo artist", "Dancer", "Gymnast", "Pilot", "Bricklayer", "Bartender", "Server", "Nurse", "Midwife",
	"Professor", "Racecar driver", "Hopscotch referee", "Footballer", "Basketball player", "Competitive swimmer",
		"Assassin (jk...)", "Web development lecturer", "Independent pizza de-cheeser", "Marriage counsellor",
	"Therapist"};

	string[] sexualities = {"Lesbian", "Gay", "Bisexual", "Pansexual", "Asexual", "Queer", "Aromantic", "Heterosexual"};

	string[] genders = { "Man", "Woman", "Non-binary", "Genderqueer", "Genderfluid"};

	// string[] pronouns = { "She/her", "He/Him", "They/Them"};

	string[] fNames = { "Lily", "Jo", "Katie", "Anna", "Laura", "Louise", "Eleanor", "Christine","Ariel",
	"Julia", "Nancy", "Rebecca", "Katy", "Naomi", "Lucy", "Lisa", "Stephanie","Ivy", "Joan", "Ashley",
	"Hannah", "Jessica", "Sara", "Carol", "Emma", "Regina", "Grace", "Alexandra", "Alex", "Sam", "Claire",
	"Rachel", "Heather", "Bea", "Amy", "Rosa","Kara", "Vicky", "Maria"};

	string[] nNames = { "Casey", "Alex", "Kim", "Sam", "Avery", "Danny", "Taylor", "Mackenzie", "Jordan",
	"Riley", "Charlie", "Peyton", "Ashton", "Ashley", "Quinn", "Skye", "Jayden", "Jamie", "Morgan",
	"Parker", "Devin", "Aubrey", "Angel", "Skylar", "Harley", "Harper", "Dallas", "Addison", "Kai",
	"Sawyer", "Micah", "Regan", "Rowan", "Teagan", "Robin", "Wren", "Jessie", "Rory", "Leaf"};
	
	string[] hobbies = { "Classical music", "Dance", "Swimming", "Running", "Computer games",
		"Poetry", "Memes", "Nature", "Hiking", "Rock climbing", "Theatre", "Cheesy jokes", "Marathons",
		"Driving", "Concerts", "Festivals", "Netflix binges", "Superheroes", "Debating"};

	string[] pets = { "Dogs", "Cats", "Rabbits", "Guinea pigs", "Hamsters", "Gerbils", "Fish"};

	string[] foods = { "Cheese", "Bread", "Fruit", "Coffee", "Cake", "Pizza", "Soup", "Pancakes",
	"Noodles", "Burgers", "Pasta", "Roast", "Fish", "Sushi"};

	string[] colours = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Grey", "White"};

	void Start () {
	//	cm.Play ();
		createPerson ();
		}
		
	public class Person {
		public string nme;
		public string occupation;
		public List<string> likes = new List<string>();
		public List<string> dislikes = new List<string>();
		public string sexuality;
		public string gender;
		public string colour;
		public bool trans;
	}

	public void createPerson(){
	//for (int i = 0; i < 50; i ++){
		Person a = new Person ();
		if ((int) Random.Range (0, 20) == 1) {
			a.trans = true;
		}
		int g = (int) Random.Range(0, genders.Length-1);
		a.gender = genders [g];
		if (g == 0) {
			a.nme = mNames [(int)Random.Range (0, mNames.Length - 1)];
			if (a.trans) {
				a.sexuality = sexualities[(int)Random.Range (1, sexualities.Length - 1)];
			} else {
				a.sexuality = sexualities[(int)Random.Range (1, sexualities.Length - 2)];
			}
		} else if (g == 1) {
			a.nme = fNames [(int)Random.Range (0, fNames.Length - 1)];
			if (a.trans) {
				a.sexuality = sexualities[(int)Random.Range (0, sexualities.Length - 1)];
			} else {
				a.sexuality = sexualities[(int)Random.Range (0, sexualities.Length - 2)];
			}
		} else {
			a.nme = nNames [(int)Random.Range (0, nNames.Length - 1)];
			a.sexuality = sexualities [(int)Random.Range (0, sexualities.Length - 1)];
		}
		a.occupation = occupations[(int)Random.Range (0, occupations.Length - 1)];
		a.likes.Add (hobbies[(int)Random.Range (0,(hobbies.Length - 1))/2]);
		a.likes.Add (hobbies[(int)Random.Range ((hobbies.Length - 1)/2,hobbies.Length - 1)]);
		a.likes.Add (foods[(int)Random.Range (0,foods.Length - 1)]);
		a.likes.Add (pets[(int)Random.Range (0,pets.Length - 1)]);
		a.colour = colours [(int)Random.Range (0, colours.Length - 1)];
		//peeps.Add (a);
		GameObject prof = Instantiate (profile);
		Profile pData = prof.GetComponent<Profile> ();
		pData.nme = a.nme;
		pData.occupation = a.occupation;
		pData.sexuality = a.sexuality;
		pData.gender = a.gender;
		pData.trans = a.trans;
		pData.likes = a.likes;
		pData.colour = a.colour;
	//}
	}
}
