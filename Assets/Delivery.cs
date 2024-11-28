using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            hasPackage = true;
            Debug.Log("Package pick up");
        }
        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
        }
    }
}
