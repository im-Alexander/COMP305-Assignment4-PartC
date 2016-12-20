using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour {

    private Transform CurrentPos;
    private Vector3 startPos;
	// Use this for initialization
	void Start ()
    {
        this.CurrentPos = GetComponent<Transform>();
        this.startPos = this.CurrentPos.position;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        
            this.transform.position = Vector3.MoveTowards(this.CurrentPos.position, this.startPos, 100f);
        
	}
}
