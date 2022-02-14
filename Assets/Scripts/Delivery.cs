using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool blHasPackage;
    [SerializeField] float fltDestroyDelay = 0.5f;
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("I've collided with something!");    
    } 

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !blHasPackage) 
        {
            Debug.Log("Package picked up.");
            blHasPackage = true;
            Destroy(other.gameObject, fltDestroyDelay);
        } 

        if (other.tag == "Customer"  && blHasPackage) 
        {
            Debug.Log("Package delivered.");
            blHasPackage = false;

        }   
    }
} // class Delivery
