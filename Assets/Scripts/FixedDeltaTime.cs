using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedDeltaTime : MonoBehaviour
{
    private float speed = 5f;

    void FixedUpdate() {
        transform.Translate (speed * Time.fixedDeltaTime, 0, 0);
        Debug.Log("Time.fixedDeltaTime value: " + Time.fixedDeltaTime + " || Frames Per Second: " +  1.0f / Time.smoothDeltaTime);
    }
}
