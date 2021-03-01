using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
     [SerializeField]
    private int serializedPrivateInt = 3;

    [SerializeField]
    private float serializedPrivateFloat = 6.6f;

    public float publicFloat = 16.52f;

    private int privateInt = 11;

    public static int publicStaticInt = 234;
}
