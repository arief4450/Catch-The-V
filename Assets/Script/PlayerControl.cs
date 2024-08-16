using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    /*public float moveSpeed = 5f;
    private Transform cameraTransform;

    void Start()
    {
        cameraTransform = gameObject.GetComponentInChildren<Transform>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = forward * moveZ + right * moveX;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }*/

    public float moveSpeed = 5f;          // Movement speed of the player
    private Transform cameraTransform;    // Reference to the camera's transform

    private float moveX = 0f;
    private float moveZ = 0f;

    void Start()
    {
        cameraTransform = gameObject.GetComponentInChildren<Transform>();
    }

    void Update()
    {
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = forward * moveZ + right * moveX;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }

    // Button functions to set movement direction
    public void MoveForward()
    {
        moveZ = 1f;
    }

    public void MoveBackward()
    {
        moveZ = -1f;
    }

    public void MoveLeft()
    {
        moveX = -1f;
    }

    public void MoveRight()
    {
        moveX = 1f;
    }

    // Stop movement when button is released
    public void StopMovingForwardBackward()
    {
        moveZ = 0f;
    }

    public void StopMovingLeftRight()
    {
        moveX = 0f;
    }
}
