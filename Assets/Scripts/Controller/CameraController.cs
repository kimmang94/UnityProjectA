using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    private float offsetX = 0.1f;
    private float offsetY = 6f;
    private float offsetZ = -8f;

    private void LateUpdate()
    {
        SetCameraPos();
    }

    private void SetCameraPos()
    {
        Vector3 fixedPos = new Vector3(target.position.x + offsetX, target.position.y + offsetY,
            target.position.z + offsetZ);
        transform.position = fixedPos;
    }
}
