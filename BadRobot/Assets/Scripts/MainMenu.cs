using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    
	public void Start_the_game ()
    {
        SceneManager.LoadScene("Level1");
	}

    public void Menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Quit_the_game ()
    {
        Application.Quit();
    }
    
}
