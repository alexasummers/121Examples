using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularTransform : MonoBehaviour
{
    private float speed = 5f;
    
    void Update()
    {
        transform.Translate (speed, 0, 0); //translate in the x direction at a constant speed of 5
    }
}
