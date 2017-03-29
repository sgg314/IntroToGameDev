using UnityEngine;
using System.Collections;

public class EnemyMovementRT : MonoBehaviour
{

    Rigidbody2D enemy;

    public float enemyStartX;           //A variable that determines the asset's starting position (X plane)
    public float enemyStartY;           //A variable that determines the asset's starting position (Y plane)
    public float enemySpeed;            //A variable that sets how fast the projectile moves.
    public int spawnID;                 //An int that registers when an enemy spawns

    public Vector2 directionToTower;    //Registers the direction toward the tower the enemies travel

    public AudioClip hitTower;          //Registers a sound for the tower getting hit
    public AudioClip hitPlayer;         //Registers a sound for the player getting hit
    private AudioSource source;         //Registers the audio source
    private float volLowRange = .5f;    //Registers the lowest volume of a sound effect
    private float volHighRange = 1.0f;  //Registers the highest volume of a sound effect

    private void Awake()
    {
        source = GameObject.Find("Audio Source").GetComponent<AudioSource>();   //Finds the audio source
    }

    // Use this for initialization
    void Start()
    {

        //enemyScript = GameObject.Find ("Enemy Spawn R").GetComponent<EnemySpawner> (); //Finds the spawner game object, and inside of it it finds the EnemySpawner script for use here
        enemyStartX = 12;//enemyScript.enemySpawnX;			//Makes enemies start at the coordinates of the tower they are spawned at
        enemyStartY = 7;//enemyScript.enemySpawnY;			//Makes enemies start at the coordinates of the tower they are spawned at

        enemy = GetComponent<Rigidbody2D>();                            //Get a reference to the rigidbody component of the enemy
        enemy.isKinematic = false;                                      //Enemy is affected by gravity

        transform.position = new Vector3(enemyStartX, enemyStartY, 0);  //Sets starting position of enemy

        directionToTower = new Vector2(5, 0) - new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

        GetComponent<Rigidbody2D>().AddForce(directionToTower.normalized * enemySpeed, ForceMode2D.Impulse); //Makes the object move to the left, and the rigidbody makes it hit the tower.
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D thingThatHitMe)        //Function triggers whenever something touches its collider. It even figures out what hit it.
    {

        if (thingThatHitMe.gameObject.name == "Tower")
        {       //The following code only occurs if the object touches the player
            Debug.Log("Tower has been hit");                    //Outputs when you hit an enemy
            float vol = Random.Range(volLowRange, volHighRange);    //Randomizes sound volume
            source.PlayOneShot(hitTower, vol);                      //Plays sound
            Destroy(this.gameObject);                           //The enemy disappears if it touches the player.
        }

        if (thingThatHitMe.gameObject.name == "Player")
        {       //The following code only occurs if the object touches the tower
            Debug.Log("Player has been hit");                   //Outputs when enemy hits tower
            float vol = Random.Range(volLowRange, volHighRange);    //Randomizes sound volume
            source.PlayOneShot(hitPlayer, vol);                     //Plays sound
            Destroy(this.gameObject);                           //The enemy disappears if it touches the tower.
        }
    }
}