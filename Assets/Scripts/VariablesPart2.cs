using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesPart2 : MonoBehaviour
{
    [SerializeField]
    private int serializedPrivateInt = 3; //private variable-- needs the [SerializeField] attribute if access in the inspector is needed

    [SerializeField]
    private float serializedPrivateFloat = 6.6f;

    public float publicFloat = 16.52f; //will show up in inspector because it is public

    private int privateInt = 11; //will not show up in inspector because it is private and does not have the [SerializeField] attribute

    public static int publicStaticInt = 234; //Not serializable-- static fields belong to the class, not an instance

    private void Start()
    {
        Debug //display the values stored in the variables
            .Log(". Serialized Private Int:" +
            serializedPrivateInt +
            "Serialized Private Float:" +
            serializedPrivateFloat +
            ". Public Float:" +
            publicFloat +
            ". Private Int:" +
            privateInt +
            ". Public Static Int:" +
            publicStaticInt
            );
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //on left click, update these variable values
        {
            serializedPrivateInt = -24;
            serializedPrivateFloat = -199;
            publicFloat = -6709;
            privateInt = -78;
            publicStaticInt = 6;
            GameObject.Instantiate (gameObject); //create clone of game object with new values
        }
    }
}
