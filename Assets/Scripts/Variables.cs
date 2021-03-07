using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    [SerializeField]
    private int serializedPrivateInt = 3; //private variable-- needs the [SerializeField] attribute if access in the inspector is needed

    [SerializeField]
    private float serializedPrivateFloat = 6.6f;

    public float publicFloat = 16.52f; //will show up in inspector because it is public

    private int privateInt = 11; //will not show up in inspector because it is private and does not have the [SerializeField] attribute

    public static int publicStaticInt = 234; //Not serializable-- static fields belong to the class, not an instance
} 
