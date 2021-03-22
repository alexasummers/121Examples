using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; //new raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //direct raycast from camera to mouse position

            if(Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;

                // Debug.Log(objectHit.name);

                MonoBehaviour[] mono; //To go through every monobehavior
                mono = objectHit.gameObject.GetComponents<MonoBehaviour>();

                foreach (MonoBehaviour item in mono)
                {
                    if (item is IDamage) //if the item is of IDamage
                    {
                        IDamage temp = item as IDamage;
                        temp.TakeDamage();
                        return;
                    }
                }
            }
        }
    }
}
