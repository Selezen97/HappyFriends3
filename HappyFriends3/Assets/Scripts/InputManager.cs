using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    private float _sidewaysMotion = 0;

    public float sidewaysMotion
    {
        get { return _sidewaysMotion; }
    }
    void Update()
    {
        Vector3 accel = Input.acceleration;
        _sidewaysMotion = accel.x;
    }
}
