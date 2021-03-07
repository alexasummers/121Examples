using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{

   public GameObject Sphere;
   public GameObject Cube;
   public GameObject Capsule;
   public GameObject Cylinder;

    public enum ShapeName //All possible states
    {
        Sphere,
        Cube,
        Capsule,
        Cylinder
    }

    public ShapeName currentShape; //causes enumerator to show up in the inspector

    void Start()
    {
        currentShape = ShapeName.Cube; //start with the Cube
    }

    void Update()
    { //switch the state of my enumerator based on what is selected from the dropdown
            switch (currentShape) 
            {
                case ShapeName.Cube: //when cube is selected
                    { 
                        Cube.SetActive(true); //set the cube active
                        Capsule.SetActive(false);
                        Cylinder.SetActive(false);
                        Sphere.SetActive(false);
                    }
            break;

                case ShapeName.Sphere: //when sphere is selected
                    {
                        Cube.SetActive(false);
                        Capsule.SetActive(false);
                        Cylinder.SetActive(false);
                        Sphere.SetActive(true); //set the sphere active
                 }
            break;

            case ShapeName.Capsule: //when  capsule is selected
                    {
                        Cube.SetActive(false);
                        Capsule.SetActive(true); //set capsule active
                        Cylinder.SetActive(false);
                        Sphere.SetActive(false);
                 }
            break;

            case ShapeName.Cylinder: //when cylinder is selected
                    {
                        Cube.SetActive(false);
                        Capsule.SetActive(false);
                        Cylinder.SetActive(true); //set cylinder active
                        Sphere.SetActive(false);
                 }
            break;
            }
        
    }

  
}