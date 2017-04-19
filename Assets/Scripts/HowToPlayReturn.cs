using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayReturn : MonoBehaviour
{
    public string BackToMenu; //Declare a public variable of type "string" and name it "startGame". "startGame" is set in the inspector.


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReturnToMenu() //Creates a new public function called "StartGame".
    {
        SceneManager.LoadScene(BackToMenu); //Loads the "startGame" scene, which in this case is the "Play Scene".
    }
}
