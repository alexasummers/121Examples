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
       parent = transform.parent; //accessing the parent of the object the script is currently on
       camera = transform; //accessing the object the script is currently on
       Cursor.lockState = CursorLockMode.Locked; //locks mouse to the center of the screen
   }

   private void Update()
   {
        float movementX = Input.GetAxis("Mouse X"); //x-axis movement
        float movementY = Input.GetAxis("Mouse Y"); //y-axis movement

        float rotationX = movementX * _mouseMovement; //x-axis rotation
        float rotationY = movementY * _mouseMovement; //y-axis rotation

        cameraClamp -= rotationY; //clamping up/down camera rotation

        Vector3 rotationCamera = camera.transform.rotation.eulerAngles; //accessing regular x/y/z rotation of camera
        Vector3 rotationModel = parent.transform.rotation.eulerAngles; //accessing regular x/y/z rotation of model


        rotationCamera.x -= rotationY; //rotate the camera
        rotationCamera.z = 0; //no change
        rotationModel.y += rotationX; //rotate the model

        if (cameraClamp > 90) { //clamp for vertical movement of camera -- 90 degrees/-90 degrees
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