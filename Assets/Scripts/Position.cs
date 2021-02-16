using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
   public Properties coroutineScript;

   void OnClick() {
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit;

       Physics.Raycast(ray, out hit);

       if (hit.collider.gameObject == gameObject)
       {
           Vector3 newGoal = hit.point + new Vector3(0, 0.5f, 0);
           coroutineScript.goal = newGoal;
       }
   }
}
