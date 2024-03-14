
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 200.0f;
    public float jumpHeight = 6.0f;
    private bool isJumping = false;

    public float pushForce = 3.0f;

    private ControllerColliderHit contact;

    public GameObject otherPlayer; // Reference to the other player object
    public float raycastDistance = 2f; // Distance for raycasting

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.S) && !isJumping)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            isJumping = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        contact = hit;

        Rigidbody body = hit.collider.attachedRigidbody;
        if (body != null && !body.isKinematic)
        {
            body.velocity = hit.moveDirection * pushForce;
        }
    }
}