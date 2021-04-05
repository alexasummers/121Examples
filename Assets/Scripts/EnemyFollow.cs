using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
  public GameObject Player; //player
  public float targetDistance; //length between enemy and raycast end
  public float allowedRange = 5; //how close the enemy can get to the player
  public GameObject Enemy; //enemy
  public float enemySpeed; //how fast the enemy is traveling
  public int attackTrigger; //state machine values
  public RaycastHit shot; //raycast emitted from enemy

  private bool showDebugGizmos = false; //gizmos initialization

  public void Update() {
      if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out shot )) { //raycast specifications
          targetDistance = shot.distance; //setting the length of the raycast equal to targetDistance

          if(targetDistance < allowedRange) //if the raycast is within the allowedRange
          {
              transform.LookAt(Player.transform); //the enemy should turn and look at the player
              enemySpeed = 0.02f; //enemy begins moving
              
              if ( attackTrigger == 0) { // state 0
                  transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, enemySpeed); //move enemy
              }
          }
        else {
            enemySpeed = 0; //if the raycast is not within the allowedRange, the enemy is not moving. 
        }
      }

      if (attackTrigger == 1) //state 1
      {
        enemySpeed = 0.0f; //enemy stops moving while attacking
        Debug.Log("I am attacking!");
      }
    }

    void OnTriggerEnter() { //when a game object collides with the trigger (Collider class)
        attackTrigger = 1; //switch states
    }

    void OnTriggerExit() { //when a collider has stopped touching the trigger (Collider class)
        attackTrigger = 0; //switch states
    }

    private void OnDrawGizmos()
    {
    Gizmos.color = Color.yellow;
    Gizmos.DrawWireSphere(Enemy.transform.position, allowedRange);

    Gizmos.color = Color.green;
    Gizmos.DrawWireSphere(Player.transform.position, 2);

    Gizmos.color = Color.red; //draw raycast
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 5;
        Gizmos.DrawRay(transform.position, direction);

        
    }
}
