using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    public GameObject[] players;

    void Start()
    {
       players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Sphere number: " + i + "Sphere Name: " + players[i].name);
        }
    }

}
