using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    private float speedAnimal = 3f;
    private bool isJump;

    // ENCAPSULATION
    public float Speed
    {
        get
        {
            return speedAnimal;
        }
        set
        {
            speedAnimal = value;
        }
    }

    // ENCAPSULATION
    public bool JumpValue
    {
        get
        {
            return isJump;
        }
        set
        {
            isJump = value;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (JumpValue == true)
        {
            Jump();
            StartCoroutine(WaitAfterJump());
        }
    }

    // POLYMORPHISM
    public virtual void AnimalJump()
    {
        speedAnimal = 3f;
    }

    // ABSTRACTION
    public void Jump()
    {
        Debug.Log(speedAnimal);
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * speedAnimal);
    }

    // ABSTRACTION
    protected IEnumerator WaitAfterJump()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(0.5f);
        JumpValue = false;
    }
}
