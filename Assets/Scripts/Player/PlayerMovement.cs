using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 8f;
    public float rotationSensitivity = 2f;
    private float verticalRotation = 0;
    private float rotationLimit = 80;
    CharacterController cc;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        //Rozgladanie sie
        float horizontalRotation = Input.GetAxis("Mouse X") * rotationSensitivity;
        transform.Rotate(0, horizontalRotation, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * rotationSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -rotationLimit, rotationLimit);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        //Poruszanie sie 
        float forwardMovement = Input.GetAxis("Vertical") * playerSpeed;
        float sidewaysMovement = Input.GetAxis("Horizontal") * playerSpeed;

        Vector3 playerMovement = new Vector3(sidewaysMovement, 0, forwardMovement);
        cc.Move(transform.rotation * playerMovement * Time.deltaTime);
    }
}
