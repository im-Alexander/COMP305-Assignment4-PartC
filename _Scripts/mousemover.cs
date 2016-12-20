using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemover : MonoBehaviour {
    private Transform _transform;
	// Use this for initialization
	void Start () {
        this._transform = this.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        this._move();
	}
    private void _move()
    {
        this._transform.position = new Vector2(Input.mousePosition.x , Input.mousePosition.y -35.0f);
    }
}
