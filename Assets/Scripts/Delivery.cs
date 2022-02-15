using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool blHasPackage;
    [SerializeField] float fltDestroyDelay = 0.5f;

    // Does not contain an overlay of color
    [SerializeField] Color32 clrHasPackageColor = new Color32(1, 1, 1, 1);

    // Does not contain an overlay of color
    [SerializeField] Color32 clrNoPackageColor = new Color32(1, 1, 1, 1);

    // The color overlays for our car
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
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
            spriteRenderer.color = clrHasPackageColor;
            Destroy(other.gameObject, fltDestroyDelay);
        } 

        if (other.tag == "Customer"  && blHasPackage) 
        {
            Debug.Log("Package delivered.");
            blHasPackage = false;
            spriteRenderer.color = clrNoPackageColor;
        }   
    }
} // class Delivery
