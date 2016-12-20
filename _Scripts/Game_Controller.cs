using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Game_Controller : MonoBehaviour 
{
	//Public Instance Variables
	[Header ("User Interface")]
	public Button OpenScreen;
	public Button Options;
	public Button StartGame;
	public Button Respawn;

	private Scene currentScene;
	private string previousScene;

	// Use this for initialization
	void Start () 
	{
        
		currentScene = SceneManager.GetActiveScene ();
        if (currentScene.name == "GameOver") 
        {
            Cursor.lockState = CursorLockMode.None;
        }
	}
	
	// Update is called once per frame
	void Update () 
	{
		/* These will check the keypad preses */
		if (Input.GetKeyDown(KeyCode.Keypad0)) 
		{
			SceneManager.LoadScene ("GameOver");
		}
		if (Input.GetKeyDown(KeyCode.Keypad1)) 
		{
			SceneManager.LoadScene ("Level1");	
		}
		if (Input.GetKeyDown(KeyCode.Keypad2)) 
		{
			SceneManager.LoadScene ("Level2");// Enter the scene name of level 2
		}
		if (Input.GetKeyDown(KeyCode.Keypad3)) 
		{
			SceneManager.LoadScene ("Level3");// Enter the scene name of level 3
		}
		if (Input.GetKeyDown(KeyCode.KeypadPeriod)) 
		{
			SceneManager.LoadScene ("Title");	
		}

	}
    void FixedUpdate()
    {


    }

    public void OptionsButton_Click ()
	{
		SceneManager.LoadScene ("Options"); // Enter the name of the options scene
	}

	public void StartButton_Click ()
	{
		SceneManager.LoadScene ("Level1"); // Enter the scenes name of the main game
	}

	public void BackButton_Click ()
	{
		SceneManager.LoadScene ("Title"); // Enter the name of the title scene
	}

	public void RespawnButton_Click ()
	{
		SceneManager.LoadScene (PlayerPrefs.GetString("Level"));
	}
	public void Update_String ()
	{
		previousScene = currentScene.name;
		PlayerPrefs.SetString ("Level", previousScene); 
	}
}
