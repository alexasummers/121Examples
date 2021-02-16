using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
   public float movement = 7f;
   public Vector3 Goal {
       get { return goal; }
       set
       {
           goal = value;

           StopCoroutine("Movement");
           StartCoroutine("Movement", goal);
       }
   }


   public Vector3 goal;

   IEnumerator Travel (Vector3 goal)
   {
       while (Vector3.Distance(transform.position, goal) > 0.05f)
       {
           transform.position = Vector3.Lerp(transform.position, goal, movement * Time.deltaTime);

           yield return null;
       }
   }
}
