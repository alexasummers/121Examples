using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private float _mouseMovement; //[SerializedField] attribute used to show private variable in the inspector-- controls how fast we want to rotate

   private Transform parent; //reference to our parent object

   private void Start() 
   {
       parent = transform.parent; //the parent of our object is the object we want to rotate
       Cursor.lockState = CursorLockMode.Locked; //locks mouse to the center of the screen
   }

   private void Update()
   {
       float movement = Input.GetAxis("Mouse X") * _mouseMovement * Time.deltaTime; //multiplying horizontal mouse movement by our mouse movement speed

        parent.Rotate(Vector3.up, movement); //rotate parent around vector3 up axis, controlled by the mouse movement
        }
}