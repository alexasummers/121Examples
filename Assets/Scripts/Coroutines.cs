using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    public float movement = 1f;
    public Transform goal;

    void Start()
    {
        StartCoroutine(ReachRed(goal));
    }


    IEnumerator ReachRed(Transform goal)
    {
        while (Vector3.Distance(transform.position, goal.position) > 0.0f)
        {
            transform.position = Vector3.Lerp(transform.position, goal.position, movement * Time.deltaTime);

            yield return null;
        }

        print ("You reached the red!");

        yield return new WaitForSeconds(3f);
        
        print("The coroutine has completed.");
    }

   
}