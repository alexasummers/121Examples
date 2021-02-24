using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private float _mouseMovement;

   private Transform parent;

   private void Start() 
   {
       parent = transform.parent;
       Cursor.lockState = CursorLockMode.Locked;
   }

   private void Update()
   {
       float movement = Input.GetAxis("Mouse X") * _mouseMovement * Time.deltaTime;

       parent.Rotate(Vector3.up, movement);
   }
}
