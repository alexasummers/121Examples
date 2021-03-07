using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedeltaTime : MonoBehaviour
{
    private float speed = 5f;

    void Update()
    {
        transform.Translate (speed * Time.deltaTime, 0, 0);
    }
}
