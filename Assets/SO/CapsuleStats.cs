using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="CapsuleData", menuName = "Capsule Stats", order = 1)]

public class CapsuleStats : ScriptableObject
{
   public int strength = 1;
   public int body = 1;
   public int will = 1;
   public string catchPhrase = "NOT SET";
}

