using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshEnemy : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent _navMeshAgent;
    public Transform goToPoint; //where the enemy is supposed to head

    Rigidbody rb;

    private void Start () 
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation; //ensures rigid body doesn't tip over
    }

    void FixedUpdate() //does not get skipped -- good place to use physics
    {
        _navMeshAgent.SetDestination(goToPoint.position); //head to the location of the player
    }

}