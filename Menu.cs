using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
    // Script to handle menu functions
    public bool HelpScreen;
    public bool mainMenu;

    public void LoadLevel(int levelIndex)
	{
		Application.LoadLevel(levelIndex);
	}
	
	public void LoadLevel(string levelName)
	{
		Application.LoadLevel(levelName);
	}
	
	public void ExitApplication()
	{
		Application.Quit();
	}
    public void ReloadLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    // Handles controller input
    void Update()
    {
        if (HelpScreen)
        {
            if (Input.GetButtonDown("Fire3"))
            {
                LoadLevel("Menu");
            }
        }
        else if (mainMenu)
        {
            if (Input.GetButtonDown("Submit"))
            {
                LoadLevel("Level");
            }
            if (Input.GetButtonDown("Reset"))
            {
                LoadLevel("Help");
            }
            if (Input.GetButtonDown("Fire3"))
            {
                ExitApplication();
            }
        }
        else
        {

        }
        
    }
}