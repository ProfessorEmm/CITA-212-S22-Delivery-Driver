using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("I've collided with something!");    
    } 

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Trigger activated");   
    }
} // class Collision
