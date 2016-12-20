using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public int NumberofMeteor;
    public GameObject Meteor;


	// Use this for initialization
	void Start ()
    {
        for (int cnt = 0; cnt < this.NumberofMeteor; cnt++)
        {
            Instantiate(this.Meteor);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
