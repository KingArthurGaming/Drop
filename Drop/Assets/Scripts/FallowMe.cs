using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowMe : MonoBehaviour
{
    public Vector3 Setting;
    void FixedUpdate()
    {
        transform.position -= Setting;
    }
}
