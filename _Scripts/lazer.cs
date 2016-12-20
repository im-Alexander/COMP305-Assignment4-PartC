using UnityEngine;
using System.Collections;

public class lazer : MonoBehaviour {
    //i used a tutorial to get the effect right. i added the partical effect myself.
    LineRenderer linerRenderer;
    //public ParticleSystem part;
    
    // Use this for initialization
    void Start()
    {
        linerRenderer = GetComponent<LineRenderer>();
        linerRenderer.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            StopCoroutine("FireLazer");
            StartCoroutine("FireLazer");
        }
    }
    IEnumerator FireLazer()
    {
        linerRenderer.enabled = true;
        while (Input.GetButton("Fire1"))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            linerRenderer.SetPosition(0, ray.origin);
            if (Physics.Raycast(ray, out hit, 400))
            {
                linerRenderer.SetPosition(1, hit.point);
                //Instantiate(this.part, hit.point, Quaternion.identity);
                if (hit.rigidbody)
                    {
                    hit.rigidbody.AddForceAtPosition(transform.forward * 100, hit.point);
                    }
                //if(hit.transform.gameObject.CompareTag("Enemy"))
                //{
                    
                //    Destroy(hit.transform.gameObject);
                //}
            }
            else
                linerRenderer.SetPosition(1, ray.GetPoint(400));
           

            yield return null;
        }
        linerRenderer.enabled = false;
    }
}
