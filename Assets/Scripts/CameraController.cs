using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private float _mouseMovement = 200; //[SerializedField] attribute used to show private variable in the inspector-- controls how fast we want to rotate

    private Transform parent; //reference to our parent object
    private Camera _fpsCamera;
    private float cameraClamp = 0f;

   private void Start() 
   {
       _fpsCamera = Camera.main;
       parent = transform.parent; //the parent of our object is the object we want to rotate
       Cursor.lockState = CursorLockMode.Locked; //locks mouse to the center of the screen
   }

   private void Update()
   {
    float horizontalRotation = Input.GetAxis("Mouse X") * _mouseMovement * Time.deltaTime; //multiplying horizontal mouse movement by our mouse movement speed
    float verticalRotation = Input.GetAxis("Mouse Y") * _mouseMovement * Time.deltaTime;
    
    parent.Rotate(0, horizontalRotation, 0); //rotate parent around vector3 up axis, controlled by the mouse movement
    _fpsCamera.transform.Rotate(-verticalRotation, 0, 0);
        }
}