using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDespown : MonoBehaviour
{

    public GameObject Object;
    void LateUpdate()
    {
        Destroy(Object, 4.4f);
    }

}
