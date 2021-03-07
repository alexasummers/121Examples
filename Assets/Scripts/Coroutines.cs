using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    public float movement = 1f;
    public Transform goal;

    void Start()
    {
        StartCoroutine(ReachRed(goal)); //Start the coroutine upon game start
    }


    IEnumerator ReachRed(Transform goal) //IEnumerator retains its current state and allows that cursor position to be passed from function to function
    {
        while (Vector3.Distance(transform.position, goal.position) > 0.0f) //while the distance between the agent and the goal is greater than zero
        {
            transform.position = Vector3.Lerp(transform.position, goal.position, movement * Time.deltaTime); //perform a linear interpolation between the agent and the target in relation to Time.deltaTime to cause a slow down upon reaching the target

            yield return null; //coroutine resumes at the yield return value. Since this is null, it will resume after next update
        }

        print ("You reached the red!"); //prints after dropping out of the loop

        yield return new WaitForSeconds(3f); //wait for three seconds
        
        print("The coroutine has completed."); //prints after wait
    }

    //drops out of coroutine
   
}