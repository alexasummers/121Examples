using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshEnemy : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent _navMeshAgent;
    public Transform goToPoint;
    private Transform raycastPoint;

    Rigidbody rb;

    private void Start () 
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        _navMeshAgent.SetDestination(goToPoint.position);
        RaycastHit hit;
        Vector3 shootRay = raycastPoint.TransformDirection(Vector3.down) * 100;
        if (Physics.Raycast(raycastPoint.position, shootRay, out hit, 100))
        {
            print (hit.point);
        }
        Vector3 moveTowardsPosition = hit.point;
        moveTowardsPosition.y = transform.position.y;

        transform.position = Vector3.MoveTowards(transform.position,moveTowardsPosition,_navMeshAgent.speed);
    }
}