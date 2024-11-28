using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField] float floatDestroy = 0.3f;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Package pick up");
            Destroy(other.gameObject, floatDestroy);
        }
        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
        }
    }
}
