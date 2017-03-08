using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DefenseUI : MonoBehaviour 
{
	public TowerBehaviour towerScript;      //Gets all the variables from TowerBehavior for use here

    public Text healthText; 				//Down in the corner: Shows your score based on how many asteroids you destroyed
	public Text youLose; 					//Pops up after all 240 asteroids are gone
    public Text timerText;                  //The timer that counts up as the player survives

    public float timeSurvived;              //The number behind the timer that counts up as the player survives

	//Activates upon starting the game
	void Start () 
	{
		towerScript = GameObject.Find ("Tower").GetComponent<TowerBehaviour> (); //Finds the tower game object, and inside of it it finds the TowerBehavior script for use here
    }
    void Update()
    {
        timeSurvived += Time.deltaTime;          //This is a timer that ticks up by the second, to show the player how long they have survived
    }
	void FixedUpdate () // Fixed Update is called one per specific time
	{
		healthText.text = "Core Health: " + towerScript.towerHealth + "/5"; 			//Shows tower's health

        if (towerScript.towerHealth > 0) //If the variable in another script is above zero...
        {
            timerText.text = "Time Survived: " + timeSurvived.ToString("F1") + " seconds";   //...it Shows timer
        }
        if (towerScript.towerHealth <= 0) //If the variable is under or equal to zero...
        {
            youLose.text = "YOU LOSE"; 	//Says the game over text
        }
        if (towerScript.towerHealth <= 1) //If the variable is under or equal to 1...
        {
            healthText.color = Color.red; //Text changes to red
        } else {
            healthText.color = Color.black; //Text remains black otherwise
        }
    }
}