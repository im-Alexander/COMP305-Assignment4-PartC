﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransportScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void onTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("");
    }
}
