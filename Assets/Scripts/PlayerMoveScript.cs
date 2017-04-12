using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {

	Rigidbody2D player;

	public float playerStartX;
	public float playerStartY;

	public SpriteRenderer playerObject;		//Store reference to spriterenderer on different gameobject

	public Sprite[] playerSprites;


	// Use this for initialization
	void Start () {

		playerStartX = 5;
		playerStartY = 1;

		player = GetComponent<Rigidbody2D> ();							//Get a reference to the rigidbody component of the player
		player.isKinematic = true;										//Player is affected by gravity

		transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets starting position of ball
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey("[8]") || Input.GetKey("w")) { //Player takes [Top] when the key is released
			playerStartX = 5;
			playerStartY = 1;
			transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets position of player
		}

		if (Input.GetKey("[2]") || Input.GetKey("x")) { //Player takes [Bottom] when the key is released
			playerStartX = 5;
			playerStartY = -1;
			transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets position of player
		}

		if (Input.GetKey("[4]") || Input.GetKey("a")) { //Player takes [Left] when the key is released
			playerStartX = 4;
			playerStartY = 0;
			transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets position of player
		}

		if (Input.GetKey("[6]") || Input.GetKey("d")) { //Player takes [Right] when the key is released
			playerStartX = 6;
			playerStartY = 0;
			transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets position of player
		}

		if (Input.GetKey("[9]") || Input.GetKey("e")) { //Player takes [Top Right] when the key is released
			playerStartX = 5.75f;
			playerStartY = .75f;
			transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets position of player
		}

		if (Input.GetKey("[7]") || Input.GetKey("q")) { //Player takes [Top Left] when the key is released
			playerStartX = 4.25f;
			playerStartY = .75f;
			transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets position of player
		}

		if (Input.GetKey("[3]") || Input.GetKey("c")) { //Player takes [Bottom Right] when the key is released
			playerStartX = 5.75f;
			playerStartY = -.75f;
			transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets position of player
		}

		if (Input.GetKey("[1]") || Input.GetKey("z")) { //Player takes [Bottom Left] when the key is released
			playerStartX = 4.25f;
			playerStartY = -.75f;
			transform.position = new Vector3 (playerStartX, playerStartY, 0);	//Sets position of player
		}


	}
}
