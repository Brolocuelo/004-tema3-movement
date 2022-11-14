using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    public float horizontalInput;

    void Update()
    {
        // transform.Translate(0, 0, 1);
        horizontalInput = Input.GetAxis("Horizontal");
        //Movimiento pa lante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //Movimiento lateral
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
