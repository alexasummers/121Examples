using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    bool isGoodBaby = true;

    public override void MakeSound(){
       Debug.Log("Meow");
    }

    public override void ContinueBreathing() {
        Debug.Log("Cat is breathing");
    }

   public void ClimbTree() {

   }
}
