using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {
    public Transform Playpos;
    public NavMeshAgent Agent;
    public float sightdis = 10.0f;
    public GameObject missle;
    private bool playersighted;

    // Use this for initialization
    void Start()
    {
        playersighted = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, fwd, out hit, sightdis))
        {
            if (hit.transform.gameObject.CompareTag("Player"))
                playersighted = true;

        }
        if (playersighted == true)
        {
            this.Agent.SetDestination(this.Playpos.position);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

        }
    }
}
