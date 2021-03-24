using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
   public string Name;
   
   public virtual void ContinueBreathing() {
       Debug.Log("No breathing detected");
   }

   public virtual void MakeSound() {
       Debug.Log("No sound detected");
   }

   void Start() {
       MakeSound();
   }

   void Update() {
     //  ContinueBreathing();
   }
}
