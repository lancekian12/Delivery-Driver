using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{


    [SerializeField] float floatDestroy = 0.3f;
    [SerializeField] Color32 hasPackageColor = new Color32(0, 255, 23, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    bool hasPackage;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
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
            spriteRenderer.color = hasPackageColor;

            Destroy(other.gameObject, floatDestroy);
        }
        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;

        }
    }
}
