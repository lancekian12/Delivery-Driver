using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 30f;


    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "BoostUp")
        {
            Debug.Log("Test");
            moveSpeed = boostSpeed;
        }


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // float steerBackward = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
