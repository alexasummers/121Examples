using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesPart2 : MonoBehaviour
{
    [SerializeField]
    private int serializedPrivateInt = 3;

    [SerializeField]
    private float serializedPrivateFloat = 6.6f;

    public float publicFloat = 16.52f;

    private int privateInt = 11;

    public static int publicStaticInt = 234;

    private void Start()
    {
        Debug
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
        if (Input.GetMouseButtonDown(0))
        {
            serializedPrivateInt = -24;
            serializedPrivateFloat = -199;
            publicFloat = -6709;
            privateInt = -78;
            publicStaticInt = 6;
            GameObject.Instantiate (gameObject);
        }
    }
}
