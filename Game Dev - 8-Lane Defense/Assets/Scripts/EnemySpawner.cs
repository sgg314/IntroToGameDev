using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public TowerBehaviour towerScript;  //This script is capable of drawing from the variables and such in TowerBehavior.
	public int enemyChooser;			//Will be a random number used to spawn enemies.
	public int spawnChooser;			//Will be a random number used to select spawn points.
	public GameObject enemy;			//Summons an enemy when necessary.
	public GameObject fastEnemy;		//Summons a fast enemy when necessary.
    public GameObject healthRestore;    //Summons a health restore when necessary.
    public float spawnTime = 10f;		//Time between enemy spawns. 3f would mean 3 seconds.
	public float enemySpawnX;			//A variable that determines the asset's starting position. (X plane)
	public float enemySpawnY;			//A variable that determines the asset's starting position. (Y plane)

	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("Spawn", spawnTime, spawnTime); //Will spawn enemies after a delay of 10 seconds.
	}
	
	// Update is called once per frame
	void Update () {

		enemyChooser = Random.Range (1,8); //Generates a random number for the purpose of spawning a random enemy. The range includes the first number, but not the second.
	}

	void Spawn ()
	{
		spawnChooser = Random.Range (1, 10);		//Chooses which enemy to spawn (Basic enemy: 5/9, Fast enemy: 3/9, Health restore: 1/9)
		GameObject spawnedEnemy = null;

		if (enemyChooser == 1) {
			//Spawns a basic enemy if the RNG chooses 1.
			spawnedEnemy = Instantiate (enemy);
		}
        if (enemyChooser == 2)
        {
            //Spawns a basic enemy if the RNG chooses 2.
            spawnedEnemy = Instantiate(enemy);
        }
        if (enemyChooser == 3)
        {
            //Spawns a health kit if the RNG chooses 3.
            spawnedEnemy = Instantiate(healthRestore);
        }
        if (enemyChooser == 4) {
            //Spawns a fast enemy if the RNG chooses 4.
            spawnedEnemy = Instantiate (fastEnemy);
		}
        if (enemyChooser == 5)
        {
            //Spawns a fast enemy if the RNG chooses 5.
            spawnedEnemy = Instantiate(fastEnemy);
        }
        if (enemyChooser == 6)
        {
            //Spawns a basic enemy if the RNG chooses 6.
            spawnedEnemy = Instantiate(enemy);
        }
        if (enemyChooser == 7)
        {
            //Spawns a basic enemy if the RNG chooses 7.
            spawnedEnemy = Instantiate(enemy);
        }
        if (enemyChooser == 8)
        {
            //Spawns a basic enemy if the RNG chooses 8.
            spawnedEnemy = Instantiate(fastEnemy);
        }
        if (enemyChooser == 9)
        {
            //Spawns a basic enemy if the RNG chooses 9.
            spawnedEnemy = Instantiate(enemy);
        }
    }
}