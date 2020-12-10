﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    //public bool RotateAroundPlayer = true;

    //public float RotationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - PlayerTransform.position;
    }

    // LateUpdate is called after Update methods
    void LateUpdate()
    {
        /*if(RotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);
            cameraOffset = camTurnAngle * cameraOffset;
        }*/

        Vector3 newPos = PlayerTransform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        if (LookAtPlayer)
            transform.LookAt(PlayerTransform);

    }

 
}
