using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    private float horizontalInput;
    private float verticalInput;
    void Update()
    {
        // Designacion de Inputs;
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Movimiento vertical
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //Movimiento lateral
        /*
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        */
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

    }
}
