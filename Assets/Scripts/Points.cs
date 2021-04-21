using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.name == "Player"){
            KeepScore.Score++;
            Destroy(gameObject);
        }
    }
}
