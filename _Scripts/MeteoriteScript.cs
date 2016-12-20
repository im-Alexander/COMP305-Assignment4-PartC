using UnityEngine;
using System.Collections;

public class MeteoriteScript : MonoBehaviour {

    private Transform transform;
    private Vector3 Target;
    private float speed = 0.5f;
    private float rotationspeed;
    
	// Use this for initialization
	void Start ()
    {
        
        transform = GetComponent<Transform>();

        reset();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        transform.position = Vector3.MoveTowards(this.transform.position,this.Target,this.speed);
        transform.Rotate(Vector3.forward, this.rotationspeed * Time.deltaTime);
        transform.Rotate(Vector3.right, this.rotationspeed * Time.deltaTime);

        if (this.transform.position == this.Target)
        {
            reset();
            
        }
        //Debug.Log(this.Target);
	}
    private void reset()
    {
        this.transform.position = new Vector3(Random.Range(-150.0f, 400.0f), Random.Range(-76.0f, 76.0f), Random.Range(-100.0f, 100.0f));
        this.Target = new Vector3(Random.Range(-150.0f, 400.0f), Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));
        this.speed = Random.Range(0.01f, 0.9f);
        this.rotationspeed = Random.Range(-7.0f, 7.0f);
       

    }
}
