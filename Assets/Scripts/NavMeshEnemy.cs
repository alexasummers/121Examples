using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshEnemy : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent _navMeshAgent;
    public Transform goToPoint; //where the enemy is supposed to head
    private Transform raycastPoint; //origin

    Rigidbody rb;

    private void Start () 
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation; //ensures rigid body doesn't tip over
    }

    void FixedUpdate() //does not get skipped -- good place to use physics
    {
        _navMeshAgent.SetDestination(goToPoint.position); //head to the location of the player
        RaycastHit hit;
        Vector3 shootRay = raycastPoint.TransformDirection(Vector3.down) * 100; //transforms local space to world space
        if (Physics.Raycast(raycastPoint.position, shootRay, out hit, 100))
        {
            print (hit.point); //where the ray hit the collider
        }
        Vector3 moveTowardsPosition = hit.point; //where the player is
        moveTowardsPosition.y = transform.position.y; //move towards the player

        transform.position = Vector3.MoveTowards(transform.position,moveTowardsPosition,_navMeshAgent.speed); //movement
    }

}