using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FPS_Controller : MonoBehaviour {

	private Game_Controller controller;

	// Use this for initialization
	void Start () 
	{
		controller = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Game_Controller> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("DeathBarrier"))
		{
			controller.Update_String ();
			SceneManager.LoadScene ("GameOver");
		}
	}
}
