using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed;
    public float rotateSpeed;
    public Transform cameraTransform;

    private void Update()
    {
        Movement();
        Rotate();
    }

    void Movement()
    {
        float inputAD;
        float inputWS;
        Vector3 inputWASD;
        inputAD = Input.GetAxis("Horizontal");
        inputWS = Input.GetAxis("Vertical");
        inputWASD = new Vector3(inputAD, 0, inputWS);

        Vector3 moveCameraDirection = cameraTransform.TransformDirection(inputWASD);
        moveCameraDirection.y = 0;
        controller.SimpleMove(moveCameraDirection * moveSpeed * Time.deltaTime);
    }

    void Rotate()
    {
        if (Mouse.current == null) return;

        float inputMouseHorizontal = Mouse.current.delta.ReadValue().x;
        transform.Rotate(0f, inputMouseHorizontal * rotateSpeed * 0.01f, 0f);
    }
}