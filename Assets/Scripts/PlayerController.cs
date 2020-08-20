using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;

    void OnMove (InputValue playerInput)
    {

        // reading player's
        Vector2 playerMovement = playerInput.Get<Vector2>();
        horizontalInput = playerMovement.x;
        verticalInput = playerMovement.y;
    }

    // Update is called once per frame
    void Update()
    {
        // move car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Rotate car right/left
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
