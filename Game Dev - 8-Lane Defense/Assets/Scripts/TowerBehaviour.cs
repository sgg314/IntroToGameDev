using UnityEngine;
using System.Collections;

public class TowerBehaviour : MonoBehaviour {

	Rigidbody2D tower;

	public int towerHealth = 5;			       //Sets the tower's health

    public float invincibleTime = 2f;          //Time until the tower becomes able to damage again. Invincibility frames.
    private float invincibleTimeCountDown;     //A real count down for invincibility
    public bool invincible = false;            //Boolean that says if it is invincible or not.


    // Use this for initialization
    void Start () {
        invincibleTimeCountDown = invincibleTime;           //Both are now stored and equal to 2
	}
	
	// Update is called once per frame
	void Update () {

		if (towerHealth <= 0) {                             //Once the tower's health reaches 0...
			Destroy (this.gameObject);                      //...the tower is destroyed, and the game ends.
		}

        if (invincible == true)
        {
            invincibleTime -= Time.deltaTime;                               //Invincible time counts down
            gameObject.GetComponent<Renderer>().material.color = Color.blue; //Changes game object to red

            if (invincibleTime <= 0f)
            {
                invincibleTime = invincibleTimeCountDown;   //Resets the value of both variables to 2 again
                invincible = false;                         //Tower is vulnerable again
            }
        } else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow; //Changes game object to red
        }
        if (towerHealth == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red; //Changes game object to red
        }
    }

	void OnTriggerEnter2D(Collider2D thingThatHitMe) 					//Function triggers whenever something touches its collider. It even figures out what hit it.
	{
		Debug.Log ("Collided with " + thingThatHitMe.gameObject.name);	//Tells the debug log if the tower was struck

		if (thingThatHitMe.gameObject.tag == "Enemy") { 		    	//The following code only occurs if the object touches an enemy
			Debug.Log ("Tower has been hit"); 							//Outputs when the tower is hit
            if (invincible == false)
            {
                towerHealth--; 											//Drop the tower's health one stage if it is hit
            }
            invincible = true;                                          //Tower is invincible.
		}

        if (thingThatHitMe.gameObject.tag == "HealthRestore")
        {                                                       //The following code only occurs if the tower touches an health restore
            if (towerHealth <= 4)                               //Only happens if the health is at 5 or lower
            {
                Debug.Log("Tower has been hit");                    //Outputs when the tower is hit
                towerHealth = towerHealth + 1; 						//Raise the tower's health one stage if it is hit
            }
        }
    }

}
