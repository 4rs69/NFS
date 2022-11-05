using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private CarMoving _car;

    [SerializeField]
    private Vector3 _offset;

    private void Start()
    {
        _car = FindObjectOfType<CarMoving>();
    }

    private void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}
