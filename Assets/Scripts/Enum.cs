using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{

   public GameObject Sphere;
   public GameObject Cube;
   public GameObject Capsule;
   public GameObject Cylinder;

    public enum ShapeName
    {
        Sphere,
        Cube,
        Capsule,
        Cylinder
    }

    public ShapeName currentShape;

    void Start()
    {
        currentShape = ShapeName.Cube;
    }

    void Update()
    {
            switch (currentShape)
            {
                case ShapeName.Cube:
                    { 
                        Sphere.SetActive(false);
                        Capsule.SetActive(false);
                        Cylinder.SetActive(false);
                        Cube.SetActive(true);
                    }
            break;

                case ShapeName.Sphere:
                    {
                        Cube.SetActive(false);
                        Capsule.SetActive(false);
                        Cylinder.SetActive(false);
                        Sphere.SetActive(true);
                 }
            break;

            case ShapeName.Capsule:
                    {
                        Cube.SetActive(false);
                        Capsule.SetActive(true);
                        Cylinder.SetActive(false);
                        Sphere.SetActive(false);
                 }
            break;

            case ShapeName.Cylinder:
                    {
                        Cube.SetActive(false);
                        Capsule.SetActive(false);
                        Cylinder.SetActive(true);
                        Sphere.SetActive(false);
                 }
            break;
            }
        
 }

  
}