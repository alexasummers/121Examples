using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    public GameObject[] players; //serialized array holding game objects-- enter the number of game objects to populate the array

    void Start()
    {
       players = GameObject.FindGameObjectsWithTag("Player"); //search for objects with the "Player" tag-- set for all sphere objects

        for (int i = 0; i < players.Length; i++) //iterate through the entire array
        {
            Debug.Log("Sphere number: " + i + "Sphere Name: " + players[i].name); //print i + the name of the sphere by referencing the array index
        }
    }

}
