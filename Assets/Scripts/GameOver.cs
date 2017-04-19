using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public string restartGame; //a string that will be used to restart the game with a click
    public string backToMenu;  //a string that will be used to go back to the menu with a click


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void RestartGame() //Will be used to restart the game
    {
        SceneManager.LoadScene(restartGame); //Loads the scene "TowerDefenseV10", restarting the game
    }

    public void BackToMenu() //will be used to go back to the menus
    {
        SceneManager.LoadScene(backToMenu); //Loads the main menu
    }
}
