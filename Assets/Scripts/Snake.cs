using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Animal
{
    bool isSheddingSkin = true;

    public override void MakeSound(){
       Debug.Log("Hiss");
   }

    public override void ContinueBreathing() {
        Debug.Log("Snake is breathing");
    }

    public void LayEgg() {
        
    }
}
