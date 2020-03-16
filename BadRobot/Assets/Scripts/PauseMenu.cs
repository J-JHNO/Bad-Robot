using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public bool showGUI = false;
    public GameObject canvas;

	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("Canvas");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            showGUI = !showGUI;
        }

        if (showGUI)
        {
            canvas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
        }

	}

    /*private void OnLevelWasLoaded()
    {
        canvas = GameObject.Find("Canvas");
    }*/

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Quit_the_game()
    {
        Application.Quit();
    }
}
