using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private CharacterController _CharacterController;
    public float speed=1;
    public float speed_rotation=3;

    private void Start()
    {
        _CharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * speed_rotation, 0);

        Vector3 forward = transform.InverseTransformDirection(Vector3.forward);

        float curspeed = speed * Input.GetAxis("Vertical");

        _CharacterController.SimpleMove(forward * curspeed);
    }
}
