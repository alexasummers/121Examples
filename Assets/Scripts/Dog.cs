using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    bool isBestBoy = true;

    int numOfHolesDug = 56;

    public override void MakeSound(){
       //base.MakeSound(); //make the sound from the parent class
       Debug.Log("Bark");
   }

    public override void ContinueBreathing() {
        Debug.Log("Dog is breathing");
    }
}
