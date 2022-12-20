using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Horse : Animal
{
    public float jumpSpeed;

    // POLYMORPHISM
    public override void AnimalJump()
    {
        // ENCAPSULATION SET
        Speed = jumpSpeed;
        // ENCAPSULATION SET
        JumpValue = true;
    }
}
