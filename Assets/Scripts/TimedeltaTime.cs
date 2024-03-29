using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedeltaTime : MonoBehaviour
{
    private float speed = 5f;

    void Update()
    {
        Debug.Log("Time.deltaTime value: " + Time.deltaTime + " || Frames Per Second: " +  1.0f / Time.smoothDeltaTime); //Displays Time.deltaTime and FPS values in console

        transform.Translate (speed * Time.deltaTime, 0, 0); //creates equal movement regardless of different fps rates
    }
}
