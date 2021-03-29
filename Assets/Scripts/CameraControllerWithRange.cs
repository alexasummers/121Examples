using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerWithRange : MonoBehaviour
{
   private float _mouseMovement = 5.0f; //mouse sensitivity of 5

   private Transform parent; //reference to our parent object (the model)
   private Transform camera; //reference to true object (FPS camera)

   float cameraClamp = 0f; //Y axis clamp for 90/-90 degree stop

   private void Start() 
   {
       parent = transform.parent;
       camera = transform;
       Cursor.lockState = CursorLockMode.Locked; //locks mouse to the center of the screen
   }

   private void Update()
   {
        float movementX = Input.GetAxis("Mouse X"); //x-axis movement
        float movementY = Input.GetAxis("Mouse Y"); //y-axis movement

        float rotationX = movementX * _mouseMovement; //x-axis rotation
        float rotationY = movementY * _mouseMovement; //y-axis rotation

        cameraClamp -= rotationY; //clamping up/down camera rotation

        Vector3 rotationCamera = camera.transform.rotation.eulerAngles;       
        Vector3 rotationModel = parent.transform.rotation.eulerAngles;


        rotationCamera.x -= rotationY;
        rotationCamera.z = 0;
        rotationModel.y += rotationX;

        if (cameraClamp > 90) {
            cameraClamp = 90;
            rotationCamera.x = 90;
        }
        else if (cameraClamp < -90)
        {
            cameraClamp = -90;
            rotationCamera.x = 270;
        }

        camera.rotation = Quaternion.Euler(rotationCamera); //Z axis, X axis and Y axis (in order)
        parent.rotation = Quaternion.Euler(rotationModel); //Z axis, X axis and Y axis (in order)
        
   }
}